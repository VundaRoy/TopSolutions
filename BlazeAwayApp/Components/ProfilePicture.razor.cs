using Microsoft.AspNetCore.Components;

namespace BlazeAwayApp.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
