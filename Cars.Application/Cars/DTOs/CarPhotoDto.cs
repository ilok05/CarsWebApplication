using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Application.Cars.DTOs
{
    public record CarPhotoDto(Guid Id, string Url, bool isMain);
}
