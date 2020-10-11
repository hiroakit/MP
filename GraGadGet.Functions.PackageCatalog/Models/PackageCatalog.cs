using System;
using System.Collections.Generic;
using System.Text;

namespace GraGadGet.Functions.PackageCatalog.Models
{
    /// <summary>
    /// パッケージのカタログ
    /// </summary>
    public class PackageCatalog
    {
        private List<Package> packages;

        /// <summary>
        /// パッケージ
        /// </summary>
        public List<Package> Packages
        {
            get { return packages; }
            set { packages = value; }
        }

        private DateTime updateDateTime;

        /// <summary>
        /// パッケージカタログの更新日時
        /// </summary>
        public DateTime UpdateDateTime
        {
            get { return updateDateTime; }
            set { updateDateTime = value; }
        }

    }

    /// <summary>
    /// パッケージのメタ情報
    /// </summary>
    public class Package
    {
        private string productId;

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private Uri homepage;

        public Uri Homepage
        {
            get { return homepage; }
            set { homepage = value; }
        }

        private string license;

        public string License
        {
            get { return license; }
            set { license = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime releaseDate;
            
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        private List<string> searchKeywordTags;
            
        public List<string> SearchKeywordTags
        {
            get { return searchKeywordTags; }
            set { searchKeywordTags = value; }
        }

        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

    }
}
