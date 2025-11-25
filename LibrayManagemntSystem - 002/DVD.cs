namespace LibrayManagemntSystem
{
    internal class DVD : IInventoryItem
    {
        public string DVDName { get; set; } = string.Empty;
        public string DVDDirector { get; set; } = string.Empty;
        public int DVDPrice { get; set; }
        public int DVDStock { get; set; }
        public int DVDYearPublished { get; set; }

        // For IInventoryItem
        public int Stock
        {
            get => DVDStock;
            set => DVDStock = value;
        }

        public DVD(string dvdname, string dvddirector, int dvdprice, int dvdstock, int dvdyearpublished)
        {
            DVDName = dvdname;
            DVDDirector = dvddirector;
            DVDPrice = dvdprice;
            DVDStock = dvdstock;
            DVDYearPublished = dvdyearpublished;
        }

        public virtual string GetDisplayInfo()
        {
            return $"DVD: {DVDName} | Director: {DVDDirector} | Price: ${DVDPrice} | Stock: {DVDStock} | Year: {DVDYearPublished}";
        }
    }

    internal class HDDVD : DVD
    {
        public string ResolutionType { get; set; }

        public HDDVD(string dvdname, string dvddirector, int dvdprice, int dvdstock, int dvdyearpublished, string resolutionType)
            : base(dvdname, dvddirector, dvdprice, dvdstock, dvdyearpublished)
        {
            ResolutionType = resolutionType;
        }

        public override string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + $" | Resolution: {ResolutionType}";
        }
    }

    internal class BluRay : DVD
    {
        public bool HasBonusContent { get; set; }

        public BluRay(string dvdname, string dvddirector, int dvdprice, int dvdstock, int dvdyearpublished, bool hasBonusContent)
            : base(dvdname, dvddirector, dvdprice, dvdstock, dvdyearpublished)
        {
            HasBonusContent = hasBonusContent;
        }

        public override string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + (HasBonusContent ? " | Bonus Content" : string.Empty);
        }
    }

    internal class VHS : DVD
    {
        public string TapeCondition { get; set; }

        public VHS(string dvdname, string dvddirector, int dvdprice, int dvdstock, int dvdyearpublished, string tapeCondition)
            : base(dvdname, dvddirector, dvdprice, dvdstock, dvdyearpublished)
        {
            TapeCondition = tapeCondition;
        }

        public override string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + $" | Condition: {TapeCondition}";
        }
    }
}
