using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_ROOMS_PARAMS")]
    public partial class AsRoomsParam
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

        public static AsRoomsParam GetAttributeValue(XmlReader item)
        {
            AsRoomsParam asRoomsParams = new AsRoomsParam();

            item.MoveToAttribute("ID");
            asRoomsParams.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asRoomsParams.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEID");
            asRoomsParams.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEIDEND");
            asRoomsParams.Changeidend = long.Parse(item.Value);
            item.MoveToAttribute("TYPEID");
            asRoomsParams.Typeid = int.Parse(item.Value);
            item.MoveToAttribute("VALUE");
            asRoomsParams.Value = item.Value;
            item.MoveToAttribute("UPDATEDATE");
            asRoomsParams.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asRoomsParams.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asRoomsParams.Enddate = DateTime.Parse(item.Value);

            return asRoomsParams;
        }
    }
}
