using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tamano_Orejas;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tamano_Orejas
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tamano_OrejasService : ITamano_OrejasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> _Tamano_OrejasRepository;
        #endregion

        #region Ctor
        public Tamano_OrejasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> Tamano_OrejasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tamano_OrejasRepository = Tamano_OrejasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> SelAll(bool ConRelaciones)
        {
            return this._Tamano_OrejasRepository.Table.ToList();
        }

        public IList<Core.Domain.Tamano_Orejas.Tamano_Orejas> SelAllComplete(bool ConRelaciones)
        {
            return this._Tamano_OrejasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tamano_OrejasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tamano_OrejasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tamano_OrejasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tamano_Orejas.Tamano_OrejasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tamano_OrejasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tamano_OrejasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tamano_OrejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas entity, Spartane.Core.Domain.User.GlobalData Tamano_OrejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas entity, Spartane.Core.Domain.User.GlobalData Tamano_OrejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

