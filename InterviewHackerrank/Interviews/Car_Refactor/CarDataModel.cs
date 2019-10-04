using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewHackerrank.Interviews.Car_Refactor
{

    public class Media
    {
        public List<string> photo_links { get; set; }
    }

    public class Dealer
    {
        public int id { get; set; }
        public string website { get; set; }
        public string name { get; set; }
        public string dealer_type { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
    }

    public class Build
    {
        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string trim { get; set; }
        public string body_type { get; set; }
        public string body_subtype { get; set; }
        public string vehicle_type { get; set; }
        public string transmission { get; set; }
        public string drivetrain { get; set; }
        public string fuel_type { get; set; }
        public string engine { get; set; }
        public double engine_size { get; set; }
        public string engine_block { get; set; }
        public int doors { get; set; }
        public int cylinders { get; set; }
        public string made_in { get; set; }
        public string steering_type { get; set; }
        public string antibrake_sys { get; set; }
        public string tank_size { get; set; }
        public string overall_height { get; set; }
        public string overall_length { get; set; }
        public string overall_width { get; set; }
        public string std_seating { get; set; }
        public string highway_miles { get; set; }
        public string city_miles { get; set; }
        public string trim_r { get; set; }
    }

    public class Listing
    {
        public string id { get; set; }
        public string vin { get; set; }
        public string heading { get; set; }
        public int price { get; set; }
        public int miles { get; set; }
        public string data_source { get; set; }
        public string vdp_url { get; set; }
        public bool carfax_1_owner { get; set; }
        public bool carfax_clean_title { get; set; }
        public string exterior_color { get; set; }
        public string interior_color { get; set; }
        public int dom { get; set; }
        public int dom_180 { get; set; }
        public int dom_active { get; set; }
        public string seller_type { get; set; }
        public string inventory_type { get; set; }
        public int last_seen_at { get; set; }
        public DateTime last_seen_at_date { get; set; }
        public int scraped_at { get; set; }
        public DateTime scraped_at_date { get; set; }
        public int first_seen_at { get; set; }
        public DateTime first_seen_at_date { get; set; }
        public int ref_price { get; set; }
        public int ref_price_dt { get; set; }
        public int ref_miles { get; set; }
        public int ref_miles_dt { get; set; }
        public string source { get; set; }
        public Media media { get; set; }
        public Dealer dealer { get; set; }
        public Build build { get; set; }
        public string stock_no { get; set; }
        public int? msrp { get; set; }
    }

    public class RootObject
    {
        public int num_found { get; set; }
        public List<Listing> listings { get; set; }
    }
}
