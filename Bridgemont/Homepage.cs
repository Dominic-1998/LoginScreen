using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Bridgemont
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            // MAP SETTINGS ON LOAD EVENT
            GMaps.Instance.Mode = AccessMode.ServerOnly; // Access Method
            gMap.MapProvider = GMapProviders.GoogleMap; // Map Provider
            gMap.Position = new PointLatLng(54.227383, -4.519171); // Centers the map
            gMap.ShowCenter = false; // Hides red cross
            gMap.DragButton = MouseButtons.Left; // Move the map with left click
            gMap.MinZoom = 2;
            gMap.MaxZoom = 18;
            gMap.Zoom = 6;
            GoogleMapProvider.Instance.Version = "m,traffic@336000000"; // Shows traffic
            timer1.Start();
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            using (ODBC.connect = new OdbcConnection(ODBC.connectionString))
            {
                object value1 = 0;
                object value2 = 0;
                OdbcCommand command = new OdbcCommand("SELECT Latitude, Longitude FROM TrackVehicles WHERE Registration = ?", ODBC.connect);
                command.Parameters.AddWithValue("?1", textBox_Registration.Text);
                try
                {
                    ODBC.connect.Open();
                    OdbcDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        value1 = reader[0];
                        value2 = reader[1];
                    }
                    reader.Close();
                    double latitude = Convert.ToDouble(value1);
                    double longitude = Convert.ToDouble(value2);
                    gMap.Position = new GMap.NET.PointLatLng(latitude, longitude);
                }
                catch (OdbcException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        public void MapMarkers(double latitude, double longitude)
        {
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.red);
            GMapOverlay overlay = new GMapOverlay();
            gMap.Overlays.Add(overlay);
            overlay.Markers.Add(marker);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (ODBC.connect = new OdbcConnection(ODBC.connectionString))
            {
                object value1 = 0;
                object value2 = 0;
                OdbcCommand command = new OdbcCommand("SELECT Latitude, Longitude FROM TrackVehicles", ODBC.connect);

                try
                {
                    ODBC.connect.Open();
                    OdbcDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        value1 = reader[0];
                        value2 = reader[1];
                        double latitude = Convert.ToDouble(value1);
                        double longitude = Convert.ToDouble(value2);
                        List<VehiclePositions> items = new List<VehiclePositions>();
                        items.Add(new VehiclePositions { Column1 = latitude, Column2 = longitude });
                        
                        MapMarkers(latitude, longitude);
                    }
                    reader.Close();
                    MessageBox.Show("Updated");
                }
                catch (OdbcException exception)
                {
                    MessageBox.Show(exception.Message);
                    timer1.Stop();
                }
            }
        }
    }
    public class VehiclePositions
    {
        public double Column1 { get; set; }
        public double Column2 { get; set; }
    }
}
