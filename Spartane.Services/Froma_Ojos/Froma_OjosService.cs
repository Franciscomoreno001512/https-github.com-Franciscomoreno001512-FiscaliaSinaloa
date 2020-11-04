using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Froma_Ojos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Froma_Ojos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Froma_OjosService : IFroma_OjosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Froma_Ojos.Froma_Ojos> _Froma_OjosRepository;
        #endregion

        #region Ctor
        public Froma_OjosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Froma_Ojos.Froma_Ojos> Froma_OjosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Froma_OjosRepository = Froma_OjosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Froma_Ojos.Froma_Ojos> SelAll(bool ConRelaciones)
        {
            return this._Froma_OjosRepository.Table.ToList();
        }

        public IList<Core.Domain.Froma_Ojos.Froma_Ojos> SelAllComplete(bool ConRelaciones)
        {
            return this._Froma_OjosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Froma_Ojos.Froma_Ojos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Froma_OjosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Froma_Ojos.Froma_Ojos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Froma_OjosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Froma_Ojos.Froma_Ojos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Froma_OjosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Froma_Ojos.Froma_OjosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Froma_OjosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Froma_Ojos.Froma_Ojos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Froma_OjosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Froma_Ojos.Froma_Ojos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Froma_Ojos.Froma_Ojos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Froma_OjosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Froma_Ojos.Froma_Ojos entity, Spartane.Core.Domain.User.GlobalData Froma_OjosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Froma_Ojos.Froma_Ojos entity, Spartane.Core.Domain.User.GlobalData Froma_OjosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

