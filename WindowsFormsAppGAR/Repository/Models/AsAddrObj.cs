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
    [Table("AS_ADDR_OBJ")]
    public partial class AsAddrObj
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Required]
        [Column("OBJECTGUID")]
        [StringLength(36)]
        public string Objectguid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        [Column("TYPENAME")]
        [StringLength(50)]
        public string Typename { get; set; }
        [Required]
        [Column("LEVEL")]
        [StringLength(10)]
        public string Level { get; set; }
        [Required]
        [Column("OPERTYPEID")]
        [StringLength(2)]
        public string Opertypeid { get; set; }
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
        [Column("ISACTUAL")]
        public bool Isactual { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }

        //Количество строк: 16014
        public static AsAddrObj GetAttributeValue(XmlElement item)
        {
            AsAddrObj asAddrObj = new AsAddrObj();

            asAddrObj.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asAddrObj.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asAddrObj.Objectguid = item.Attributes.GetNamedItem("OBJECTGUID").Value;
            asAddrObj.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asAddrObj.Name = item.Attributes.GetNamedItem("NAME").Value;
            asAddrObj.Typename = item.Attributes.GetNamedItem("TYPENAME").Value;
            asAddrObj.Level = item.Attributes.GetNamedItem("LEVEL").Value;
            asAddrObj.Opertypeid = item.Attributes.GetNamedItem("OPERTYPEID").Value;

            if (item.HasAttribute("PREVID"))
                asAddrObj.Previd = long.Parse(item.Attributes.GetNamedItem("PREVID").Value);
            else
                asAddrObj.Previd = null;

            if (item.HasAttribute("NEXTID"))
                asAddrObj.Nextid = long.Parse(item.Attributes.GetNamedItem("NEXTID").Value);
            else
                asAddrObj.Nextid = null;

            asAddrObj.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asAddrObj.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asAddrObj.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);
            
            string IsactualValue = item.Attributes.GetNamedItem("ISACTUAL").Value;            
            if (IsactualValue == "1")
                asAddrObj.Isactual = true;
            else
                asAddrObj.Isactual = false;

            string IsactiveValue = item.Attributes.GetNamedItem("ISACTIVE").Value;
            if (IsactiveValue == "1")
                asAddrObj.Isactive = true;
            else
                asAddrObj.Isactive = false;

            return asAddrObj;
        }
    }
}
