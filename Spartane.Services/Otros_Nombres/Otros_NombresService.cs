using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Otros_Nombres;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Otros_Nombres
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Otros_NombresService : IOtros_NombresService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> _Otros_NombresRepository;
        #endregion

        #region Ctor
        public Otros_NombresService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> Otros_NombresRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Otros_NombresRepository = Otros_NombresRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> SelAll(bool ConRelaciones)
        {
            return this._Otros_NombresRepository.Table.ToList();
        }

        public IList<Core.Domain.Otros_Nombres.Otros_Nombres> SelAllComplete(bool ConRelaciones)
        {
            return this._Otros_NombresRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Otros_NombresRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Otros_NombresRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Otros_NombresRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Otros_Nombres.Otros_NombresPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Otros_NombresPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Otros_NombresRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Otros_Nombres.Otros_Nombres GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Otros_Nombres.Otros_Nombres result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Otros_NombresInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Otros_Nombres.Otros_Nombres entity, Spartane.Core.Domain.User.GlobalData Otros_NombresInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Otros_Nombres.Otros_Nombres entity, Spartane.Core.Domain.User.GlobalData Otros_NombresInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

