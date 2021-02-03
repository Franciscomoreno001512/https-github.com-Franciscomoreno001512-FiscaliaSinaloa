using System;
using Spartane.Core.Domain.Formulacion_de_Imputacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Formulacion_de_Imputacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IFormulacion_de_ImputacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_ImputacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
