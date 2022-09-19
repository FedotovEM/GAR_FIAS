using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_HOUSES_PARAMS")]
    public partial class AsHousesParam
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

        public static AsHousesParam GetAttributeValue(XmlReader item)
        {
            AsHousesParam asHousesParams = new AsHousesParam();

            item.MoveToAttribute("ID");
            asHousesParams.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asHousesParams.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEID");
            asHousesParams.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEIDEND");
            asHousesParams.Changeidend = long.Parse(item.Value);
            item.MoveToAttribute("TYPEID");
            asHousesParams.Typeid = int.Parse(item.Value);
            item.MoveToAttribute("VALUE");
            asHousesParams.Value = item.Value;
            item.MoveToAttribute("UPDATEDATE");
            asHousesParams.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asHousesParams.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asHousesParams.Enddate = DateTime.Parse(item.Value);

            return asHousesParams;
        }
    }
}
