using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tamano_de_Cejas;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tamano_de_Cejas
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tamano_de_CejasService : ITamano_de_CejasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> _Tamano_de_CejasRepository;
        #endregion

        #region Ctor
        public Tamano_de_CejasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> Tamano_de_CejasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tamano_de_CejasRepository = Tamano_de_CejasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> SelAll(bool ConRelaciones)
        {
            return this._Tamano_de_CejasRepository.Table.ToList();
        }

        public IList<Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> SelAllComplete(bool ConRelaciones)
        {
            return this._Tamano_de_CejasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tamano_de_CejasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tamano_de_CejasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tamano_de_CejasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_CejasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tamano_de_CejasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tamano_de_CejasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tamano_de_CejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas entity, Spartane.Core.Domain.User.GlobalData Tamano_de_CejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas entity, Spartane.Core.Domain.User.GlobalData Tamano_de_CejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

