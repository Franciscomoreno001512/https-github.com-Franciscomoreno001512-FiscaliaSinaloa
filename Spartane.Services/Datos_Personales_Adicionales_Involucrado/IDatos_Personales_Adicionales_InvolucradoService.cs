using System;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Datos_Personales_Adicionales_Involucrado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDatos_Personales_Adicionales_InvolucradoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_InvolucradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
