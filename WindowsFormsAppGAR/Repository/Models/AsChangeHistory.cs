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
    [Table("AS_CHANGE_HISTORY")]
    public partial class AsChangeHistory
    {
        [Key]
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Required]
        [Column("ADROBJECTID")]
        [StringLength(36)]
        public string Adrobjectid { get; set; }
        [Column("OPERTYPEID")]
        public int Opertypeid { get; set; }
        [Column("NDOCID")]
        public long? Ndocid { get; set; }
        [Column("CHANGEDATE", TypeName = "date")]
        public DateTime Changedate { get; set; }

        public static AsChangeHistory GetAttributeValue(XmlElement item)
        {
            AsChangeHistory asChangeHistory = new AsChangeHistory();

            asChangeHistory.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asChangeHistory.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asChangeHistory.Adrobjectid = item.Attributes.GetNamedItem("ADROBJECTID").Value;
            asChangeHistory.Opertypeid = int.Parse(item.Attributes.GetNamedItem("OPERTYPEID").Value);

            if (item.HasAttribute("NDOCID"))
                asChangeHistory.Ndocid = long.Parse(item.Attributes.GetNamedItem("NDOCID").Value);
            else
                asChangeHistory.Ndocid = null;

            asChangeHistory.Changedate = DateTime.Parse(item.Attributes.GetNamedItem("CHANGEDATE").Value);
           
            return asChangeHistory;
        }
    }
}
