using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMS.UserInterface.Pages.Shared
{
    public class BasePageModel : PageModel
    {
        //public readonly IHttpContextAccessor _contextAccessor;
        //public readonly IMediator _mediator;
        //public UserIdentityData _userData = new ();
        //public BasePageModel(IHttpContextAccessor contextAccessor, IMediator mediator)
        //{
        //    _contextAccessor = contextAccessor;
        //    _mediator= mediator;
        //}

        //protected UserIdentityData UserData
        //{
        //    get
        //    {
        //        var claims = _contextAccessor.HttpContext.User.Claims;

        //        _userData = new UserIdentityData
        //        {
        //            UserId = claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid).Value.ToString(),
        //            Username = claims.FirstOrDefault(p => p.Type == ClaimTypes.Name).Value.ToString(),
        //            Role = claims.FirstOrDefault(p => p.Type == ClaimTypes.Role).Value.ToString(),
        //            FullName = claims.FirstOrDefault(p => p.Type == ClaimTypes.GivenName).Value.ToString()
        //        };

        //        return _userData;
        //    }
        //    set
        //    {
        //        if (value == null)
        //        {
        //            throw new ArgumentNullException(nameof(value));
        //        }

        //        _userData = value;
        //    }
        //}
        //protected async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
        //{
        //    return await _mediator.Send(request);
        //}
    }
}