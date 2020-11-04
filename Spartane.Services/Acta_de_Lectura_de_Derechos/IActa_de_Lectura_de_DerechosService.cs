using System;
using Spartane.Core.Domain.Acta_de_Lectura_de_Derechos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Acta_de_Lectura_de_Derechos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IActa_de_Lectura_de_DerechosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
