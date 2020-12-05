using System;
using Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Resultado_de_Investigacion_Complementaria
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IResultado_de_Investigacion_ComplementariaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_ComplementariaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
