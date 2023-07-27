using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Dtos.security
{
    public class MenuModuleDto
    {
        public MenuModuleDto()
        {
            this.MenuMenuDtos = new List<MenuMenuDto>();
        }
        public short MenuModuleId { get; set; }
        public string MenuModuleName { get; set; }
        public string MenuModuleLink { get; set; }
        public string MenuModuleCss { get; set; }
        public short MenuModuleOrder { get; set; }
        public List<MenuMenuDto> MenuMenuDtos { get; set; }
    }

    public class MenuMenuDto
    {
        public MenuMenuDto()
        {
            this.MenuSubMenuDtos = new List<MenuSubMenuDto>();
        }
        public string MenuMenuId { get; set; }
        public short MenuModuleId { get; set; }
        public string MenuMenuName { get; set; }
        public string MenuMenuLink { get; set; }
        public string MenuMenuCss { get; set; }
        public int MenuMenuOrder { get; set; }
        public List<MenuSubMenuDto> MenuSubMenuDtos { get; set; }
    }

    public class MenuSubMenuDto
    {
        public short MenuSubMenuId { get; set; }
        public short MenuMenuId { get; set; }
        public string MenuSubMenuName { get; set; }
        public string MenuSubMenuLink { get; set; }
        public string MenuSubMenuCss { get; set; }
        public short MenuSubMenuOrder { get; set; }
    }
}
