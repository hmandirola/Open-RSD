﻿using Msn.InteropDemo.Entities.Activity;
using Msn.InteropDemo.ViewModel.Activity;

namespace Msn.InteropDemo.AppServices.Implementation.Mapping.Profiles
{
    public class LogActiviyProfile : AutoMapper.Profile
    {
        public LogActiviyProfile()
        {
            CreateMap<ActivityLog, ActivityLogListItemViewModel>()
                .ForMember(dest => dest.ActivityTypeDescriptorName, orig => orig.MapFrom(x => x.ActivityTypeDescriptor.Nombre))
                .ForMember(dest => dest.CreatedDateTimeUI, orig => orig.MapFrom(x => x.CreatedDateTime.ToString("dd/MM/yyyy hh:mm:ss")));

            CreateMap<ActivityLog, ActivityLogViewModel>();
        }
    }
}
