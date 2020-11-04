using System;
using Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Catalogo_Tipo_de_Cargo_CC
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICatalogo_Tipo_de_Cargo_CCService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
