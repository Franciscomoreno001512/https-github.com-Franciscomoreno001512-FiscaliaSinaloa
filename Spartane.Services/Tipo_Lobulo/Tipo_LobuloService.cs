using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_Lobulo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_Lobulo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_LobuloService : ITipo_LobuloService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo> _Tipo_LobuloRepository;
        #endregion

        #region Ctor
        public Tipo_LobuloService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo> Tipo_LobuloRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_LobuloRepository = Tipo_LobuloRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo> SelAll(bool ConRelaciones)
        {
            return this._Tipo_LobuloRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_Lobulo.Tipo_Lobulo> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_LobuloRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_LobuloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_LobuloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_LobuloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Lobulo.Tipo_LobuloPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_LobuloPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_LobuloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_LobuloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo entity, Spartane.Core.Domain.User.GlobalData Tipo_LobuloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo entity, Spartane.Core.Domain.User.GlobalData Tipo_LobuloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

