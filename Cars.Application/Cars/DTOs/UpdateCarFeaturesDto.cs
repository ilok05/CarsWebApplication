using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Application.Cars.DTOs
{
    public record UpdateCarFeaturesDto(List<Guid> FeatureIds);
}
