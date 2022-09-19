using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_CARPLACES_PARAMS")]
    public partial class AsCarplacesParam
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("CHANGEIDEND")]
        public long Changeidend { get; set; }
        [Column("TYPEID")]
        public int Typeid { get; set; }
        [Required]
        [Column("VALUE")]
        [StringLength(36)]
        public string Value { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }

        public static AsCarplacesParam GetAttributeValue(XmlReader item)
        {
            AsCarplacesParam asCarplacesParams = new AsCarplacesParam();

            item.MoveToAttribute("ID");
            asCarplacesParams.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asCarplacesParams.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEID");
            asCarplacesParams.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEIDEND");
            asCarplacesParams.Changeidend = long.Parse(item.Value);
            item.MoveToAttribute("TYPEID");
            asCarplacesParams.Typeid = int.Parse(item.Value);
            item.MoveToAttribute("VALUE");
            asCarplacesParams.Value = item.Value;
            item.MoveToAttribute("UPDATEDATE");
            asCarplacesParams.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asCarplacesParams.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asCarplacesParams.Enddate = DateTime.Parse(item.Value);

            return asCarplacesParams;
        }
    }
}
