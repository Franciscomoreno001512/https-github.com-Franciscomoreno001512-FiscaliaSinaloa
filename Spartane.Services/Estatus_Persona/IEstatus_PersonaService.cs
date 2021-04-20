using System;
using Spartane.Core.Domain.Estatus_Persona;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Estatus_Persona
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEstatus_PersonaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Estatus_Persona.Estatus_Persona> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_Persona.Estatus_Persona> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_Persona.Estatus_Persona> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Estatus_Persona.Estatus_Persona GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Estatus_Persona.Estatus_Persona entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Estatus_Persona.Estatus_Persona entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Estatus_Persona.Estatus_Persona> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Estatus_Persona.Estatus_Persona> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Estatus_Persona.Estatus_PersonaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Estatus_Persona.Estatus_Persona> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
