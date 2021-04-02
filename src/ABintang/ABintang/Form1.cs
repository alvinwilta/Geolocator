using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private string filename;
        //private string algorithm = "null";
        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GMapProvider.GoogleMap.ApiKey = AppConfig.Key;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.BingOSMap;
            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLong.Text);
            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;

            PointLatLng point = new PointLatLng(lat,longt);
            GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            //Create Overlay
            GMapOverlay markers = new GMapOverlay("markers");

            //Add all available markers to overlay
            markers.Markers.Add(marker);

            //Cover Map with Overlay
            map.Overlays.Add(markers);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void map_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnGetRouteInfo_Click(object sender, EventArgs e)
        {
            /*var route = GoogleMapProvider.Instance.
                GetRoute(_points[0], _points[1], false, false, 14);
            var r = new GMapRoute(route.Points, "My Route")
            {
                Stroke = new Pen(Color.Red, 5)
            };
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);*/
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(_points[0]);
            points.Add(_points[1]);
            //points.Add(new PointLatLng(48.863868, 2.321554));
            //points.Add(new PointLatLng(48.861017, 2.330030));
            GMapRoute route = new GMapRoute(points, "A walk in the park");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            map.Overlays.Add(routes);
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
                g = new Graph(input.Node);
                g.InputGraph(input.DataNode, input.Kamus);
                this.renderGraph();
                // clear combobox
                /*this.comboBox1.Items.Clear();
                this.comboBox2.Items.Clear();
                // add nodes to combobox
                this.comboBox1.Items.AddRange(input.Kamus.Values.ToArray());
                this.comboBox2.Items.AddRange(input.Kamus.Values.ToArray());
                this.comboBox2.Items.Add("");*/
                //button1.Enabled = true;
            }
        }

        private void renderGraph()
        {
            // re-attach the graph to viewer
            // essentially, "update" the view with latest graph
            viewer.Graph = g.GetGraph();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
