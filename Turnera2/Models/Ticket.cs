using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turnera2.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        public DateOnly Fecha { get; set; }
        public TimeOnly Hora { get; set; }
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
        [ForeignKey("PacienteId")]
        public Paciente Paciente  { get; set; }

        /*
        public override string ToString()
        {
            Medico medico = AccesoADatos.BuscarMedico(medicoId);
            Paciente paciente = AccesoADatos.BuscarPaciente(pacienteId);
            return ($"-------------------------------------------- \n" +
                $"Turno: {fecha} / {hora} \n" +
                $"Especialidad: {Enum.GetName(typeof(Especialidad),medico.Especialidad)}\n" +
                $"Dr. {medico.NombreCompleto}\n" +
                $"Paciente: {paciente.NombreCompleto}\n" +
                $"Cobertura: {Enum.GetName(typeof(ObraSocial), paciente.ObraSocial)}\n");
        }
        */
    }
}