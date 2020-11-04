using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Color_Ojos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Color_Ojos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Color_OjosService : IColor_OjosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Color_Ojos.Color_Ojos> _Color_OjosRepository;
        #endregion

        #region Ctor
        public Color_OjosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Color_Ojos.Color_Ojos> Color_OjosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Color_OjosRepository = Color_OjosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> SelAll(bool ConRelaciones)
        {
            return this._Color_OjosRepository.Table.ToList();
        }

        public IList<Core.Domain.Color_Ojos.Color_Ojos> SelAllComplete(bool ConRelaciones)
        {
            return this._Color_OjosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Color_OjosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Color_OjosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Color_OjosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Color_Ojos.Color_OjosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Color_OjosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Color_OjosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Color_Ojos.Color_Ojos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Color_Ojos.Color_Ojos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Color_OjosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Color_Ojos.Color_Ojos entity, Spartane.Core.Domain.User.GlobalData Color_OjosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Color_Ojos.Color_Ojos entity, Spartane.Core.Domain.User.GlobalData Color_OjosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

