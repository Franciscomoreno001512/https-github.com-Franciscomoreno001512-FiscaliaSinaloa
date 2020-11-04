using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Documentos_Requeridos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Documentos_Requeridos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Documentos_RequeridosService : IDetalle_Documentos_RequeridosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> _Detalle_Documentos_RequeridosRepository;
        #endregion

        #region Ctor
        public Detalle_Documentos_RequeridosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> Detalle_Documentos_RequeridosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Documentos_RequeridosRepository = Detalle_Documentos_RequeridosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Documentos_RequeridosRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Documentos_RequeridosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Documentos_RequeridosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Documentos_RequeridosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Documentos_RequeridosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_RequeridosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Documentos_RequeridosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Documentos_RequeridosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Documentos_RequeridosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos entity, Spartane.Core.Domain.User.GlobalData Detalle_Documentos_RequeridosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos entity, Spartane.Core.Domain.User.GlobalData Detalle_Documentos_RequeridosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

