using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Acta_de_Lectura_de_Derechos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Acta_de_Lectura_de_Derechos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Acta_de_Lectura_de_DerechosService : IActa_de_Lectura_de_DerechosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> _Acta_de_Lectura_de_DerechosRepository;
        #endregion

        #region Ctor
        public Acta_de_Lectura_de_DerechosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> Acta_de_Lectura_de_DerechosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Acta_de_Lectura_de_DerechosRepository = Acta_de_Lectura_de_DerechosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> SelAll(bool ConRelaciones)
        {
            return this._Acta_de_Lectura_de_DerechosRepository.Table.ToList();
        }

        public IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> SelAllComplete(bool ConRelaciones)
        {
            return this._Acta_de_Lectura_de_DerechosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Acta_de_Lectura_de_DerechosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Acta_de_Lectura_de_DerechosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Acta_de_Lectura_de_DerechosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Acta_de_Lectura_de_DerechosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Acta_de_Lectura_de_DerechosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Acta_de_Lectura_de_DerechosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos entity, Spartane.Core.Domain.User.GlobalData Acta_de_Lectura_de_DerechosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos entity, Spartane.Core.Domain.User.GlobalData Acta_de_Lectura_de_DerechosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

