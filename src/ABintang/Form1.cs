using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;

namespace ABintang
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _points;
        //private Button currentButton;
        private Input input;
        private Graph g;
        // private Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer;
        //private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private string filename;
        //private string algorithm = "null";
        private List<string> nodelist1;
        private List<string> nodelist2;
        private double latitude;
        private double longitude;
        private double zoom;
        private double latitude2;
        private double longitude2;
        private double zoom2;
        //private GMapOverlay overlayTemp;
        //private GMarkerGoogle markerTemp;
        private PointLatLng tempPoint;
        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            map.MapProvider = GMapProviders.BingOSMap;
            map2.MapProvider = GMapProviders.BingOSMap;
            map.DragButton = MouseButtons.Left;
            map2.DragButton = MouseButtons.Left;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map2.MinZoom = 5;
            map2.MaxZoom = 100;
            nodelist1 = new List<string>();
            nodelist2 = new List<string>();
            tempPoint = new PointLatLng();
            input = new Input();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void map_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
        }

        
        private void btnGetRouteInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboStart.Text) && !string.IsNullOrEmpty(comboFinish.Text))
            {
                if (map.Overlays.Any(x => x.Id == "routes"))
                {
                    GMapOverlay hapus = map.Overlays.First(x => x.Id == "routes");
                    map.Overlays.Remove(hapus);
                }
                latitude = map.Position.Lat;
                longitude = map.Position.Lng;
                zoom = map.Zoom;
     
                label3.Text = "";
                AddPathSisi1();
                List<PointLatLng> points = new List<PointLatLng>();
                // buat variabel point, TranslatetoName() sama cek input
            
                labelErrorRoute.Text = "";
                List<Point> Solusi = g.ABintangShortestPath(input.Kamus, g.TranslatetoName(input.Kamus, comboStart.SelectedItem.ToString()), g.TranslatetoName(input.Kamus, comboFinish.SelectedItem.ToString()));
                for (int i = 0; i < Solusi.Count; i++)
                {
                    label3.Text += Solusi[i].Getname();
                    points.Add(new PointLatLng(Solusi[i].Getlat(), Solusi[i].Getlongt()));
                    if (i != Solusi.Count - 1)
                    {
                        label3.Text += " -> ";
                    }
                }
                label3.Text += "\nJarak =";
                label3.Text += Convert.ToString(g.HitungJarak(input.Kamus, Solusi));
                label3.Text += " km";
                GMapOverlay routes = new GMapOverlay("routes");
                GMapRoute route = new GMapRoute(points, "rute");
                route.Stroke = new Pen(Color.Red, 3);
                routes.Routes.Add(route);
                map.Overlays.Add(routes);

                //GMapProvider.GoogleMap.ApiKey = AppConfig.Key;
                map.DragButton = MouseButtons.Left;

                map.Position = new PointLatLng(latitude, longitude);
                map.MinZoom = 3;
                map.MaxZoom = 100;
                map.Zoom = zoom;
            } 
            else
            {
                labelErrorRoute.Text = "Node pair incomplete";
            }
            
        }

        private void BtnInputDir_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                this.FileDir.Text = filename;
                // parse input
                input = new Input(filename);
                // initialize graph
                g = new Graph(input.nodeinp);
                g.InputGraph(input.DataNode, input.Kamus);
                //TODO
                //points.Add(_points[0]);
                //points.Add(_points[1]);
                map.Overlays.Clear();
                AddPathSisi1();
                foreach (var x in input.Kamus)
                {
                    double lat2 = x.Value.Getlat();
                    double longt2 = x.Value.Getlongt();
                    PointLatLng point2 = new PointLatLng(lat2, longt2);
                    GMarkerGoogle marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.blue_dot);
                    var addresses = GetAddress(point2);
                    if (addresses != null)
                    {
                        marker2.ToolTipText = x.Value.Getname() + String.Join(", ", addresses.ToArray());
                    }
                    else
                    {
                        marker2.ToolTipText = x.Value.Getname();
                    }
                    //Create Overlay
                    GMapOverlay markers2 = new GMapOverlay("markers");

                    //Add all available markers to overlay
                    markers2.Markers.Add(marker2);

                    //Cover Map with Overlay
                    map.Overlays.Add(markers2);
                }
                //GMapProvider.GoogleMap.ApiKey = AppConfig.Key;
                map.DragButton = MouseButtons.Left;
                //map.MapProvider = GMapProviders.BingOSMap;
                double lat = input.GetMiddleCoords().Getlat();
                double longt = input.GetMiddleCoords().Getlongt();
                map.Position = new PointLatLng(lat, longt);
                map.MinZoom = 3;
                map.MaxZoom = 100;
                map.Zoom = 16;

                //Create Combobox of nodes
                comboStart.Items.Clear();
                comboFinish.Items.Clear();
                foreach (var entry in input.Kamus)
                {
                    comboStart.Items.Add(entry.Value.Getname());
                    comboFinish.Items.Add(entry.Value.Getname());
                }
                //comboStart.DataSource = nodelist1;
                //comboFinish.DataSource = nodelist2;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //map2.DragButton = MouseButtons.Left;
            labelExport.Text = "";
            if (checkInputValid(txtLatitude.Text) && checkInputValid(txtLongitude.Text))
            {
                labelError2.Text = "";
                double lat = Convert.ToDouble(txtLatitude.Text);
                double lng = Convert.ToDouble(txtLongitude.Text);
                map2.Position = new PointLatLng(lat, lng);
                map2.MinZoom = 3;
                map2.MaxZoom = 100;
                map2.Zoom = 15;
                // inisialisasi input lagi tapi input kosong
            } 
            else
            {
                labelError2.Text = "Wrong input";
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // default Position
        private void button3_Click(object sender, EventArgs e)
        {
            labelExport.Text = "";
            map2.Position = new PointLatLng(-6.891235014541753, 107.61071274138624);
            map2.Zoom = 15;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            map2.ShowCenter = false;
        }
        private Boolean checkInputValid(String input)
        {
            Double d;
            return Double.TryParse(input, out d);
        }

        private void comboStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboFinish_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private List<string> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
            if(/*statusCode == GeoCoderStatusCode.G_GEO_SUCCESS &&*/ placemarks!= null)
            {
                List<string> addresses = new List<string>();
                foreach(var placemark in placemarks)
                {
                    addresses.Add(placemark.Address);
                }
                return addresses;
            }
            return null;
        }

        private void map2_Click(object sender, EventArgs e)
        {

        }

        private void map2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //if (!newoverlay)
                //{
                    
                //}
                
                latitude2 = map2.Position.Lat;
                longitude2 = map2.Position.Lng;
                zoom2 = map2.Zoom;
                map2.Overlays.Clear();
                AddPathSisi2();
                foreach (var x in input.Kamus)
                {
                    double lat2 = x.Value.Getlat();
                    double longt2 = x.Value.Getlongt();
                    PointLatLng point2 = new PointLatLng(lat2, longt2);
                    GMarkerGoogle marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.blue_dot);
                    var addresses = GetAddress(point2);
                    if (addresses != null)
                    {
                        marker2.ToolTipText = x.Value.Getname() + String.Join(", ", addresses.ToArray());
                    }
                    else
                    {
                        marker2.ToolTipText = x.Value.Getname();
                    }
                    //Create Overlay
                    GMapOverlay markers2 = new GMapOverlay("markers");

                    //Add all available markers to overlay
                    markers2.Markers.Add(marker2);

                    //Cover Map with Overlay
                    map2.Overlays.Add(markers2);
                }

                var point = map2.FromLocalToLatLng(e.X, e.Y);
                tempPoint = new PointLatLng(point.Lat, point.Lng);
                GMarkerGoogle markerTemp = new GMarkerGoogle(map2.FromLocalToLatLng(e.X, e.Y), GMarkerGoogleType.red_dot);
                GMapOverlay overlayTemp = new GMapOverlay("markers");
                overlayTemp.Markers.Add(markerTemp);
                map2.Overlays.Add(overlayTemp);
                //newoverlay = true;
                //map2.DragButton = MouseButtons.Left;

                map2.Position = new PointLatLng(latitude2, longitude2);
                map2.MinZoom = 3;
                map2.MaxZoom = 100;
                map2.Zoom = zoom2;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(sfd.FileName);
                //Write a line of text
                sw.WriteLine(Convert.ToString(input.Kamus.Count));
                foreach (var a in input.Kamus)
                {
                    sw.WriteLine(Convert.ToString(a.Value.Getlat() + " " + a.Value.Getlongt() + " " + a.Value.Getname()).Replace(",", "."));

                }
                for(int x = 0; x < input.hubungan.Count; x++)
                {
                    for (int y = 0; y < input.hubungan.ElementAt(x).Count; y++)
                    {
                        sw.Write(Convert.ToString(input.hubungan.ElementAt(x).ElementAt(y)).Replace(",", "."));
                        if (y != input.hubungan.ElementAt(x).Count - 1)
                        {
                            sw.Write(" ");
                        }
                    }
                    if (x != input.hubungan.Count - 1)
                    {
                        sw.WriteLine();
                    }
                }
                sw.Close();
                labelExport.Text = "File has been successfully created.";
                input.ClearInputClass();
                map2.Overlays.Clear();
                comboNode1.Items.Clear();
                comboNode2.Items.Clear();
            }
        }

        private void buttonAddPointManual_Click(object sender, EventArgs e)
        {
            labelExport.Text = "";
            if (!string.IsNullOrEmpty(textboxPointName.Text))
            {
                if (tempPoint == null)
                {
                    labelErrorPoint.Text = "No point selected!";
                }
                else
                {
                    if (input.CheckDuplName(textboxPointName.Text) )
                    {
                        labelErrorPoint.Text = "There are already point with that name!";
                    }
                    else
                    {
                        labelErrorPoint.Text = "";
                        input.AddKamusData(tempPoint.Lat, tempPoint.Lng, textboxPointName.Text);
                        comboNode1.Items.Add(textboxPointName.Text);
                        comboNode2.Items.Add(textboxPointName.Text);
                    }
                }
            }
            else
            {
                labelErrorPoint.Text = "Please insert a name";
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            input.ClearInputClass();
            map2.Overlays.Clear();
            comboNode1.Items.Clear();
            comboNode2.Items.Clear();
        }

        private void check_Click(object sender, EventArgs e)
        {
            labelExport.Text = "";
            MessageBox.Show(input.CheckAdjMatrix());
        }

        private void checkAdjMat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(input.CheckAdjMatrix());
        }

        private void buttonAddSisi_Click(object sender, EventArgs e)
        {
            labelExport.Text = "";
            if (!string.IsNullOrEmpty(comboNode1.SelectedItem.ToString()) && !string.IsNullOrEmpty(comboNode2.SelectedItem.ToString()))
            {
                if (comboNode1.SelectedItem.ToString() != comboNode2.SelectedItem.ToString())
                {
                    if (!input.IsSisiAda(comboNode1.SelectedItem.ToString(), comboNode2.SelectedItem.ToString()))
                    {
                        labelErrorSisi.Text = "";
                        input.AddSisi(comboNode1.SelectedItem.ToString(), comboNode2.SelectedItem.ToString());
                        latitude2 = map2.Position.Lat;
                        longitude2 = map2.Position.Lng;
                        zoom2 = map2.Zoom;
                        map2.Overlays.Clear();
                        AddPathSisi2(); 
                        foreach (var x in input.Kamus)
                        {
                            double lat2 = x.Value.Getlat();
                            double longt2 = x.Value.Getlongt();
                            PointLatLng point2 = new PointLatLng(lat2, longt2);
                            GMarkerGoogle marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.blue_dot);
                            var addresses = GetAddress(point2);
                            if (addresses != null)
                            {
                                marker2.ToolTipText = x.Value.Getname() + String.Join(", ", addresses.ToArray());
                            }
                            else
                            {
                                marker2.ToolTipText = x.Value.Getname();
                            }
                            //Create Overlay
                            GMapOverlay markers2 = new GMapOverlay("markers");

                            //Add all available markers to overlay
                            markers2.Markers.Add(marker2);

                            //Cover Map with Overlay
                            map2.Overlays.Add(markers2);
                        }
                        map2.Position = new PointLatLng(latitude2, longitude2);
                        map2.MinZoom = 3;
                        map2.MaxZoom = 100;
                        map2.Zoom = zoom2;
                    }
                    else
                    {
                        labelErrorSisi.Text = "Sisi sudah ada pada graf!";
                    }
                }
                else
                {
                    labelErrorSisi.Text = "Tidak bisa ke diri sendiri!";
                }
            }
            else
            {
                labelErrorSisi.Text = "Pasangan node tidak lengkap!";
            }
        }

        private void AddPathSisi1()
        {
            List<List<int>> solusi = input.IterasiAdjList();
            int i = 0;
            foreach (var sol in solusi)
            {
                List<PointLatLng> points = new List<PointLatLng>();
                points.Add(new PointLatLng(input.Kamus[sol[0]].Getlat(), input.Kamus[sol[0]].Getlongt()));
                points.Add(new PointLatLng(input.Kamus[sol[1]].Getlat(), input.Kamus[sol[1]].Getlongt()));
                GMapOverlay routes = new GMapOverlay("routes");
                GMapRoute route = new GMapRoute(points, "rute");
                route.Stroke = new Pen(Color.Blue, 3);
                routes.Routes.Add(route);
                map.Overlays.Add(routes);
            } 
        }
        private void AddPathSisi2()
        {
            List<List<int>> solusi = input.IterasiAdjList();
            foreach (var sol in solusi)
            {
                List<PointLatLng> points = new List<PointLatLng>();
                points.Add(new PointLatLng(input.Kamus[sol[0]].Getlat(), input.Kamus[sol[0]].Getlongt()));
                points.Add(new PointLatLng(input.Kamus[sol[1]].Getlat(), input.Kamus[sol[1]].Getlongt()));
                GMapOverlay routes = new GMapOverlay("routes");
                GMapRoute route = new GMapRoute(points, "rute");
                route.Stroke = new Pen(Color.Blue, 3);
                routes.Routes.Add(route);
                map2.Overlays.Add(routes);
            }
        }
    }
}
