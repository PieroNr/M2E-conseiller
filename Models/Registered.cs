using M2E_conseiller.Enums;

namespace M2E_conseiller.Models;

public class Registered
{
    public string BNI { get; set; }
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Referent Referent { get; set; }
    public ModalityType Modality { get; set; }
    
}