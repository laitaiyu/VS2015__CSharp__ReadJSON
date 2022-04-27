using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace ReadJSON
{
    public partial class Form1 : Form
    {
        private String cwbopendata_xmlns;
        private String cwbopendata_identifier;
        private String cwbopendata_sender;
        private String cwbopendata_sent;
        private String cwbopendata_status;
        private String cwbopendata_msgType;
        private String cwbopendata_dataid;
        private String cwbopendata_scope;
        private String cwbopendata_dataset;

        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            "AttachDbFilename=|DataDirectory|DB1.mdf;" +
            "Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessHeader();
            ProcessWeather();
        }


        private void ProcessHeader(String ofFile = "O-A0001-001.json")
        {
            String FilePath = ofFile;
            if (File.Exists(FilePath))
            {
                FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                StreamReader file = new StreamReader(fs, System.Text.Encoding.UTF8);
                JsonTextReader reader = new JsonTextReader(file);
                JObject jo = (JObject)JToken.ReadFrom(reader);
                cwbopendata_xmlns = jo["cwbopendata"]["@xmlns"].ToString();
                cwbopendata_identifier = jo["cwbopendata"]["identifier"].ToString();
                cwbopendata_sender = jo["cwbopendata"]["sender"].ToString();
                cwbopendata_sent = jo["cwbopendata"]["sent"].ToString();
                cwbopendata_status = jo["cwbopendata"]["status"].ToString();
                cwbopendata_msgType = jo["cwbopendata"]["msgType"].ToString();
                cwbopendata_dataid = jo["cwbopendata"]["dataid"].ToString();
                cwbopendata_scope = jo["cwbopendata"]["scope"].ToString();
                cwbopendata_dataset = jo["cwbopendata"]["dataset"].ToString();
                reader.Close();
                file.Close();
                fs.Close();
            }
            else
            {
                return;
            }

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = strConn;
                cn.Open();
                if (cn.State == ConnectionState.Open)
                {
                    String strSQL_Header = "SELECT * FROM Header WHERE identifier = '" + cwbopendata_identifier + "'";
                    DataTable dt = new DataTable();
                    SqlDataAdapter daHeader = new SqlDataAdapter(strSQL_Header, cn);
                    daHeader.Fill(dt);
                    cbbIdentifier.DataSource = dt;
                    cbbIdentifier.DisplayMember = "identifier";
                    if (dt.Rows.Count == 0)
                    {
                        String strSQL = "INSERT INTO Header(xmlns,identifier,sender,sent,status,msgType,dataid,scope,dataset) " +
                            "values(@xmlns,@identifier,@sender,@sent,@status,@msgType,@dataid,@scope,@dataset)";
                        SqlCommand cmd = new SqlCommand(strSQL, cn);
                        cmd.Parameters.AddWithValue("@xmlns", cwbopendata_xmlns);
                        cmd.Parameters.AddWithValue("@identifier", cwbopendata_identifier);
                        cmd.Parameters.AddWithValue("@sender", cwbopendata_sender);
                        cmd.Parameters.AddWithValue("@sent", cwbopendata_sent);
                        cmd.Parameters.AddWithValue("@status", cwbopendata_status);
                        cmd.Parameters.AddWithValue("@msgType", cwbopendata_msgType);
                        cmd.Parameters.AddWithValue("@dataid", cwbopendata_dataid);
                        cmd.Parameters.AddWithValue("@scope", cwbopendata_scope);
                        cmd.Parameters.AddWithValue("@dataset", cwbopendata_dataset);
                        cmd.ExecuteNonQuery();
                        daHeader.Fill(dt);
                    }

                    textBoxXmlns.Text = dt.Rows[0]["xmlns"].ToString(); //cwbopendata_xmlns;
                    //cbbIdentifier.Text = dt.Rows[0]["identifier"].ToString(); //cwbopendata_identifier;
                    textBoxSender.Text = dt.Rows[0]["sender"].ToString(); //cwbopendata_sender;
                    textBoxSent.Text = dt.Rows[0]["sent"].ToString(); //cwbopendata_sent;
                    textBoxStatus.Text = dt.Rows[0]["status"].ToString(); //cwbopendata_status;
                    textBoxMsgType.Text = dt.Rows[0]["msgType"].ToString(); //cwbopendata_msgType;
                    textBoxDataid.Text = dt.Rows[0]["dataid"].ToString(); //cwbopendata_dataid;
                    textBoxScope.Text = dt.Rows[0]["scope"].ToString(); //cwbopendata_scope;
                    textBoxDataset.Text = dt.Rows[0]["dataset"].ToString(); //cwbopendata_dataset;
                }
            }

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = strConn;
                cn.Open();
                if (cn.State == ConnectionState.Open)
                {
                    String strSQL_Header = "SELECT * FROM Header";
                    DataTable dt = new DataTable();
                    SqlDataAdapter daHeader = new SqlDataAdapter(strSQL_Header, cn);
                    daHeader.Fill(dt);
                    cbbIdentifier.DataSource = dt;
                    cbbIdentifier.DisplayMember = "identifier";
                }
            }
        }

        private void ProcessWeather(String ofFile = "O-A0001-001.json")
        {
            String FilePath = ofFile;
            if (File.Exists(FilePath))
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = strConn;
                    cn.Open();
                    if (cn.State == ConnectionState.Open)
                    {
                        DataTable dt = new DataTable();
                        String strWeather = "SELECT * FROM Weather WHERE identifier = '" + cbbIdentifier.Text + "'";
                        SqlDataAdapter daWeather = new SqlDataAdapter(strWeather, cn);
                        daWeather.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            System.Threading.Thread.CurrentThread.CurrentCulture =
                                System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

                            System.IO.StreamReader objStreamReader = new System.IO.StreamReader(FilePath,
                                System.Text.Encoding.UTF8);
                            
                            String JSON_Content = objStreamReader.ReadToEnd();
                            objStreamReader.Close();

                            JObject objJObject = JObject.Parse(JSON_Content);
                            JToken locationList = objJObject.SelectToken("cwbopendata.location");
                            long lCount = 0;

                            foreach (JToken location in locationList)
                            {
                                lCount++;
                                String lat = location.SelectToken("lat").Value<float>().ToString();
                                String lon = location.SelectToken("lon").Value<float>().ToString();
                                String lat_wgs84 = location.SelectToken("lat_wgs84").Value<float>().ToString();
                                String lon_wgs84 = location.SelectToken("lon_wgs84").Value<float>().ToString();
                                String locationName = location.SelectToken("locationName").Value<string>();
                                String stationId = location.SelectToken("stationId").Value<string>();
                                String obsTime = location.SelectToken("time").Value<string>("obsTime");
                                String strWeatherElement = "";
                                String strWeatherElementValue = "";
                                JToken weatherList = location.SelectToken("weatherElement");
                                foreach (JToken weather in weatherList)
                                {
                                    strWeatherElement += weather.SelectToken("elementName").Value<string>() + ",";
                                    if (weather.SelectToken("elementValue").Value<string>("value").ToString().Length < 8)
                                    {
                                        strWeatherElementValue += weather.SelectToken("elementValue").Value<string>("value").ToString() + ",";
                                    }
                                    else
                                    {
                                        strWeatherElementValue += "'" + weather.SelectToken("elementValue").Value<DateTime>("value").ToString() + "',";
                                    }
                                }

                                String strParameterElement = "";
                                String[] strParameterElementValue = new String[4];
                                int idx = 0;
                                JToken parameterList = location.SelectToken("parameter");
                                foreach (JToken parameter in parameterList)
                                {
                                    strParameterElement += parameter.SelectToken("parameterName").Value<string>() + ",";
                                    strParameterElementValue[idx++] = parameter.SelectToken("parameterValue").Value<string>();
                                }
                                strParameterElement = strParameterElement.Substring(0, strParameterElement.Length - 1);

                                String strSQL = "INSERT INTO Weather(identifier,lat,lon,lat_wgs84,lon_wgs84,locationName," + 
                                    "stationId,obsTime," + strWeatherElement + strParameterElement + ") " +
                                    "values(@identifier,@lat,@lon,@lat_wgs84,@lon_wgs84,@locationName," + 
                                    "@stationId,@obsTime," + strWeatherElementValue + "@CITY,@CITY_SN,@TOWN,@TOWN_SN)";
                                
                                SqlCommand cmd = new SqlCommand(strSQL, cn);
                                cmd.Parameters.AddWithValue("@identifier", cbbIdentifier.Text);
                                cmd.Parameters.AddWithValue("@lat", lat);
                                cmd.Parameters.AddWithValue("@lon", lon);
                                cmd.Parameters.AddWithValue("@lat_wgs84", lat_wgs84);
                                cmd.Parameters.AddWithValue("@lon_wgs84", lon_wgs84);
                                cmd.Parameters.AddWithValue("@locationName", locationName);
                                cmd.Parameters.AddWithValue("@stationId", stationId);
                                cmd.Parameters.AddWithValue("@obsTime", obsTime);
                                cmd.Parameters.AddWithValue("@CITY", strParameterElementValue[0]); 
                                cmd.Parameters.AddWithValue("@CITY_SN", strParameterElementValue[1]); 
                                cmd.Parameters.AddWithValue("@TOWN", strParameterElementValue[2]); 
                                cmd.Parameters.AddWithValue("@TOWN_SN", strParameterElementValue[3]);
                                cmd.ExecuteNonQuery();
                            }
                            daWeather.Fill(dt);
                            textBoxRowCount.Text = lCount.ToString();
                            MessageBox.Show("Record Inserted Successfully");
                            /*
                            //把要處理的 JSON 字串複製到 http://json2csharp.chahuo.com/ 得到C#類，
                            //把這部分內容複製，貼上到 class Program 類的下方。
                            //傳入字串，得到物件。這方法確實可行，但在本程式中並沒有使用到。
                            RootObject obj = JsonConvert.DeserializeObject<RootObject>(JSON_Content); 
                            textBox1.Text += obj.cwbopendata.location[0].weatherElement[0].elementName.ToString();
                            */
                        }
                        else
                        {
                            textBoxRowCount.Text = dt.Rows.Count.ToString();
                        }
                    }
                }
                DisplayHeader();
                DisplayWeather();
            }
            else
            {
                return;
            }
        }

        private void DisplayHeader()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = strConn;
                cn.Open();
                if (cn.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();
                    String strWeather = "SELECT * FROM Header WHERE identifier = '" + cbbIdentifier.Text + "'";
                    SqlDataAdapter daWeather = new SqlDataAdapter(strWeather, cn);
                    daWeather.Fill(dt);
                    textBoxXmlns.Text = dt.Rows[0]["xmlns"].ToString(); //cwbopendata_xmlns;
                    //cbbIdentifier.Text = dt.Rows[0]["identifier"].ToString(); //cwbopendata_identifier;
                    textBoxSender.Text = dt.Rows[0]["sender"].ToString(); //cwbopendata_sender;
                    textBoxSent.Text = dt.Rows[0]["sent"].ToString(); //cwbopendata_sent;
                    textBoxStatus.Text = dt.Rows[0]["status"].ToString(); //cwbopendata_status;
                    textBoxMsgType.Text = dt.Rows[0]["msgType"].ToString(); //cwbopendata_msgType;
                    textBoxDataid.Text = dt.Rows[0]["dataid"].ToString(); //cwbopendata_dataid;
                    textBoxScope.Text = dt.Rows[0]["scope"].ToString(); //cwbopendata_scope;
                    textBoxDataset.Text = dt.Rows[0]["dataset"].ToString(); //cwbopendata_dataset;
                }
            }
        }

        private void DisplayWeather()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = strConn;
                cn.Open();
                if (cn.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();
                    String strWeather = "SELECT * FROM Weather WHERE identifier = '" + cbbIdentifier.Text + "' " + 
                        " ORDER BY locationName ASC, CITY DESC";
                    SqlDataAdapter daWeather = new SqlDataAdapter(strWeather, cn);
                    daWeather.Fill(dt);
                    dgvWeather.DataSource = dt;
                    dgvWeather.Columns[0].Visible = false;
                    dgvWeather.Columns[1].Visible = false;
                    dgvWeather.ReadOnly = cbxReadOnly.Checked;
                    textBoxRowCount.Text = dt.Rows.Count.ToString();
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdWeather.ShowDialog() == DialogResult.OK)
            {
                ProcessHeader(ofdWeather.FileName);
                ProcessWeather(ofdWeather.FileName);
                DisplayHeader();
                DisplayWeather();
            }
        }

        private void cbbIdentifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayHeader();
            DisplayWeather();
        }

        private void cbxReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            dgvWeather.ReadOnly = cbxReadOnly.Checked;
        }
    }
}
