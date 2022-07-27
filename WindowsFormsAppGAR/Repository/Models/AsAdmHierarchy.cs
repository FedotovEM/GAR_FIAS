using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsFormsAppGAR.Repository.Models
{
    [Table("AS_ADM_HIERARCHY")]
    public partial class AsAdmHierarchy
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Column("PARENTOBJID")]
        public long? Parentobjid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("REGIONCODE")]
        [StringLength(4)]
        public string Regioncode { get; set; }
        [Column("AREACODE")]
        [StringLength(4)]
        public string Areacode { get; set; }
        [Column("CITYCODE")]
        [StringLength(4)]
        public string Citycode { get; set; }
        [Column("PLACECODE")]
        [StringLength(4)]
        public string Placecode { get; set; }
        [Column("PLANCODE")]
        [StringLength(4)]
        public string Plancode { get; set; }
        [Column("STREETCODE")]
        [StringLength(4)]
        public string Streetcode { get; set; }
        [Column("PREVID")]
        public long? Previd { get; set; }
        [Column("NEXTID")]
        public long? Nextid { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }
        [Required]
        [Column("PATH", TypeName = "text")]
        public string Path { get; set; }

        public static AsAdmHierarchy GetAttributeValue(XmlElement item)
        {
            AsAdmHierarchy asAdmHierarchy = new AsAdmHierarchy();

            asAdmHierarchy.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asAdmHierarchy.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            
            if (item.HasAttribute("PARENTOBJID"))
                asAdmHierarchy.Parentobjid = long.Parse(item.Attributes.GetNamedItem("PARENTOBJID").Value);
            else
                asAdmHierarchy.Parentobjid = null;
            
            asAdmHierarchy.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asAdmHierarchy.Regioncode = item.Attributes.GetNamedItem("REGIONCODE").Value;
            asAdmHierarchy.Areacode = item.Attributes.GetNamedItem("AREACODE").Value;
            asAdmHierarchy.Citycode = item.Attributes.GetNamedItem("CITYCODE").Value;
            asAdmHierarchy.Placecode = item.Attributes.GetNamedItem("PLACECODE").Value;

            asAdmHierarchy.Plancode = item.Attributes.GetNamedItem("PLANCODE").Value;
            asAdmHierarchy.Streetcode = item.Attributes.GetNamedItem("STREETCODE").Value;
            
            if (item.HasAttribute("PREVID"))
                asAdmHierarchy.Previd = long.Parse(item.Attributes.GetNamedItem("PREVID").Value);
            else
                asAdmHierarchy.Previd = null;

            if (item.HasAttribute("NEXTID"))
                asAdmHierarchy.Nextid = long.Parse(item.Attributes.GetNamedItem("NEXTID").Value);
            else
                asAdmHierarchy.Nextid = null;

            asAdmHierarchy.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asAdmHierarchy.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asAdmHierarchy.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            string IsactiveValue = item.Attributes.GetNamedItem("ISACTIVE").Value;
            if (IsactiveValue == "1")
                asAdmHierarchy.Isactive = true;
            else
                asAdmHierarchy.Isactive = false;

            asAdmHierarchy.Path = item.Attributes.GetNamedItem("PATH").Value;
            return asAdmHierarchy;
        }
    }
}
