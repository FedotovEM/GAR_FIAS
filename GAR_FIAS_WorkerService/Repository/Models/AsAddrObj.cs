using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
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

        public static AsAddrObj GetAttributeValue(XmlReader item)
        {
            AsAddrObj asAddrObj = new AsAddrObj();

            item.MoveToAttribute("ID");
            asAddrObj.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asAddrObj.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTGUID");
            asAddrObj.Objectguid = item.Value;
            item.MoveToAttribute("CHANGEID");
            asAddrObj.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asAddrObj.Name = item.Value;
            item.MoveToAttribute("TYPENAME");
            asAddrObj.Typename = item.Value;
            item.MoveToAttribute("LEVEL");
            asAddrObj.Level = item.Value;
            item.MoveToAttribute("OPERTYPEID");
            asAddrObj.Opertypeid = item.Value;

            if (item.MoveToAttribute("PREVID"))
                asAddrObj.Previd = long.Parse(item.Value);
            else
                asAddrObj.Previd = null;

            if (item.MoveToAttribute("NEXTID"))
                asAddrObj.Nextid = long.Parse(item.Value);
            else
                asAddrObj.Nextid = null;

            item.MoveToAttribute("UPDATEDATE");
            asAddrObj.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asAddrObj.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asAddrObj.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTUAL");

            string IsactualValue = item.Value;
            if (IsactualValue == "1")
                asAddrObj.Isactual = true;
            else
                asAddrObj.Isactual = false;

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1")
                asAddrObj.Isactive = true;
            else
                asAddrObj.Isactive = false;

            return asAddrObj;
        }
    }
}
