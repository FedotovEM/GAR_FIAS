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
    [Table("AS_MUN_HIERARCHY")]
    public partial class AsMunHierarchy
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
        [Required]
        [Column("OKTMO")]
        [StringLength(11)]
        public string Oktmo { get; set; }
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

        public static AsMunHierarchy GetAttributeValue(XmlElement item)
        {
            AsMunHierarchy asMunHierarchy = new AsMunHierarchy();

            asMunHierarchy.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asMunHierarchy.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);

            if (item.HasAttribute("PARENTOBJID"))
                asMunHierarchy.Parentobjid = long.Parse(item.Attributes.GetNamedItem("PARENTOBJID").Value);
            else
                asMunHierarchy.Parentobjid = null;

            asMunHierarchy.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asMunHierarchy.Oktmo = item.Attributes.GetNamedItem("OKTMO").Value;
            
            if (item.HasAttribute("PREVID"))
                asMunHierarchy.Previd = long.Parse(item.Attributes.GetNamedItem("PREVID").Value);
            else
                asMunHierarchy.Previd = null;

            if (item.HasAttribute("NEXTID"))
                asMunHierarchy.Nextid = long.Parse(item.Attributes.GetNamedItem("NEXTID").Value);
            else
                asMunHierarchy.Nextid = null;

            asMunHierarchy.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asMunHierarchy.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asMunHierarchy.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            string IsactiveValue = item.Attributes.GetNamedItem("ISACTIVE").Value;
            if (IsactiveValue == "1")
                asMunHierarchy.Isactive = true;
            else
                asMunHierarchy.Isactive = false;

            asMunHierarchy.Path = item.Attributes.GetNamedItem("PATH").Value;

            return asMunHierarchy;
        }
    }
}
