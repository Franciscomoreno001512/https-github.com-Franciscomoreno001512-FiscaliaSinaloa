using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Modo_de_Asegurado_de_Drogas
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Modo_de_Asegurado_de_DrogasService : IModo_de_Asegurado_de_DrogasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> _Modo_de_Asegurado_de_DrogasRepository;
        #endregion

        #region Ctor
        public Modo_de_Asegurado_de_DrogasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> Modo_de_Asegurado_de_DrogasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Modo_de_Asegurado_de_DrogasRepository = Modo_de_Asegurado_de_DrogasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> SelAll(bool ConRelaciones)
        {
            return this._Modo_de_Asegurado_de_DrogasRepository.Table.ToList();
        }

        public IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> SelAllComplete(bool ConRelaciones)
        {
            return this._Modo_de_Asegurado_de_DrogasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modo_de_Asegurado_de_DrogasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Modo_de_Asegurado_de_DrogasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modo_de_Asegurado_de_DrogasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Modo_de_Asegurado_de_DrogasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Modo_de_Asegurado_de_DrogasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Modo_de_Asegurado_de_DrogasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas entity, Spartane.Core.Domain.User.GlobalData Modo_de_Asegurado_de_DrogasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas entity, Spartane.Core.Domain.User.GlobalData Modo_de_Asegurado_de_DrogasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

