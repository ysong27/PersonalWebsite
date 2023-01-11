namespace PersonalWebsite.Models
{
    public class ResumeItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageFileName { get; set; }
        public string SectionType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public List<string> Descriptions { get; set; }

        public ResumeItem(int id, string title, string imageFileName, string sectionType, DateTime fromDate, DateTime toDate, List<string> descriptions) 
        {
            this.Id = id;
            this.Title = title;
            this.ImageFileName = imageFileName;
            this.SectionType = sectionType;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.Descriptions = descriptions;
        }
    }


    public class Education : ResumeItem
    {
        public string City { get; set; }
        public string Province { get; set; }

        public Education(int id, string title, string imageFileName, DateTime fromDate, DateTime toDate, List<string> descriptions, string city, string province) 
            : base(id, title, imageFileName, "Education", fromDate, toDate, descriptions) 
        {
            this.City = city;
            this.Province = province;
        }
    }

    public class Work : ResumeItem
    {
        public string City { get; set; }
        public string Province { get; set; }

        public Work(int id, string title, string imageFileName, DateTime fromDate, DateTime toDate, List<string> descriptions, string city, string province)
            : base(id, title, imageFileName, "Work", fromDate, toDate, descriptions)
        {
            this.City = city;
            this.Province = province;
        }
    }

    public class Certification : ResumeItem
    {
        public Certification(int id, string title, string imgUrl, DateTime fromDate, DateTime toDate, List<string> descriptions)
            : base(id, title, imgUrl, "Certification", fromDate, toDate, descriptions) {}
    }
}
