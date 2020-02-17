using BlazorConfListPWA.DTO;
using BlazorConfListPWA.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorConfListPWA.Pages
{
    public partial class Conferences : ComponentBase
    {
        private List<Conference> _conferences = new List<Conference>();

        [Inject]
        private ConferencesService _conferencesService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var result = await _conferencesService.GetConferences();
            _conferences = result.Conferences;
        }
    }
}
