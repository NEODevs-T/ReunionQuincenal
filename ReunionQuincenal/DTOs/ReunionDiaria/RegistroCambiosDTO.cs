
namespace ReunionWeb.ReunionDiaria.DTOs;

public class RegistroCambiosDTO
{
    public RegistroCambiosDTO(CambFecDTO cambFecDTO, CambStatDTO cambStatDTO, ReunionDTO regisReudia)
    {
        this.cambFecDTO = cambFecDTO;
        this.cambStatDTO = cambStatDTO;
        this.regisReudia = regisReudia;
    }
    public CambFecDTO? cambFecDTO { get; set; }
    public CambStatDTO? cambStatDTO { get; set; }
    public ReunionDTO? regisReudia { get; set; }
}