using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_documentos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_documentos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_documentosService : IDetalle_de_documentosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos> _Detalle_de_documentosRepository;
        #endregion

        #region Ctor
        public Detalle_de_documentosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos> Detalle_de_documentosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_documentosRepository = Detalle_de_documentosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_documentosRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_documentos.Detalle_de_documentos> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_documentosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_documentosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_documentosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_documentosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_documentosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_documentosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_documentosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos entity, Spartane.Core.Domain.User.GlobalData Detalle_de_documentosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos entity, Spartane.Core.Domain.User.GlobalData Detalle_de_documentosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

