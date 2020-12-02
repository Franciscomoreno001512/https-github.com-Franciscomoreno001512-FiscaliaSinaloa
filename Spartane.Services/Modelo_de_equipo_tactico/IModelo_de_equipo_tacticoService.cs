using System;
using Spartane.Core.Domain.Modelo_de_equipo_tactico;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Modelo_de_equipo_tactico
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IModelo_de_equipo_tacticoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
