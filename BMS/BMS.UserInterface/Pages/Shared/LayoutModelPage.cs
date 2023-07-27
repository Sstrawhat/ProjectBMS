using BMS.Application.Dtos.security;
using BMS.UserInterface.Pages.Shared;

namespace BMS.UserInterface.Pages.Shared
{
    public class LayoutModelPage : BasePageModel
    {
        //public LayoutModelPage(IHttpContextAccessor contextAccessor, IMediator mediator) : base(contextAccessor, mediator)
        //{
        //}

        public string GetMenu()
        {

            var menumodule = new List<MenuModuleDto> {
                new MenuModuleDto { MenuModuleName = "User Security", MenuModuleLink = "#", MenuModuleCss = "align-self-center menu-icon fas fa-users",
                    MenuMenuDtos = new List<MenuMenuDto>
                    {
                        new MenuMenuDto { MenuMenuName = "Accounts", MenuMenuLink = "../Admin/UserSecurity/UserAccount/_PageAction?handler=List", MenuMenuCss = "ti-control-record"},
                        new MenuMenuDto { MenuMenuName = "Registered Account", MenuMenuLink = "../Admin/UserSecurity/RegisterAccount/_PageAction?handler=List", MenuMenuCss = "ti-control-record"},
                    }
                },
                new MenuModuleDto { MenuModuleName = "Configurations", MenuModuleLink = "#", MenuModuleCss = "align-self-center menu-icon fas fa-cogs",
                MenuMenuDtos = new List<MenuMenuDto>
                    {
                        new MenuMenuDto { MenuMenuName = "Notifications", MenuMenuLink = "../Admin/Configuration/_PageAction?handler=Form", MenuMenuCss = "ti-control-record"},
                        new MenuMenuDto { MenuMenuName = "Security Config", MenuMenuLink = "../Admin/Configuration/_PageAction?handler=Form", MenuMenuCss = "ti-control-record"},
                        new MenuMenuDto { MenuMenuName = "Portal Settings", MenuMenuLink = "../Admin/Configuration/_PageAction?handler=Form", MenuMenuCss = "ti-control-record"},
                    }
                }
            };


            var html = $"""<ul class="metismenu left-sidenav-menu">""";


            foreach (var module in menumodule)
            {

                if (module.MenuMenuDtos.Count() <= 1)
                {
                    html += $"""<li class="menu-label mt-0"><a class="nav-link" href="{module.MenuModuleLink}"><i class="{module.MenuModuleCss}"></i><span>{module.MenuModuleName}</span></a></li>""";
                    continue;
                }

                html += $"""
                        <li>
                            <a class="nav-link" href="{module.MenuModuleLink}"><i class="{module.MenuModuleCss}"></i><span>{module.MenuModuleName}</span><span class="menu-arrow"><i class="mdi mdi-chevron-right"></i></span></a>
                            <ul>
                        """;
                foreach (var menu in module.MenuMenuDtos)
                {
                    if (menu.MenuSubMenuDtos.Count() <= 1)
                    {
                        html += $"""<li><a class="nav-link" href="{menu.MenuMenuLink}"><i class="{menu.MenuMenuCss}"></i><span>{menu.MenuMenuName}</span></a></li>""";
                        continue;
                    }
                    html += $"""
                        <li>
                            <a href="{menu.MenuMenuLink}"><i class="{menu.MenuMenuCss}"></i><span>{menu.MenuMenuName}</span><span class="menu-arrow"><i class="mdi mdi-chevron-right"></i></span></a>
                            <ul>
                        """;

                    foreach (var submenu in menu.MenuSubMenuDtos)
                    {
                        html += $"""<li><a class="nav-link" href="{submenu.MenuSubMenuLink}"><i class="{submenu.MenuSubMenuCss}"></i><span>{submenu.MenuSubMenuName}</span></a></li>""";
                    }

                    html += $"""
                            </ul>
                        </li>
                        """;
                }


                html += $"""
                            </ul>
                        </li>
                        """;
            
            }

            html += "</ul>";

            return html;
        }

        //public async Task<UserIdentityData> GetUserData()
        //{
        //    var response = new UserIdentityData()
        //    {
        //        FullName = this.UserData.FullName
        //    };

        //    return response;
        //}
    }
}