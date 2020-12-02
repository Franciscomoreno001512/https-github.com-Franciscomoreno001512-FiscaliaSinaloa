using System;
using Spartane.Core.Domain.Marca_de_Equipo_Tactico;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Marca_de_Equipo_Tactico
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IMarca_de_Equipo_TacticoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_TacticoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
