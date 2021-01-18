using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Queja_Sugerencia_Ciudadana;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Queja_Sugerencia_Ciudadana
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Queja_Sugerencia_CiudadanaService : IQueja_Sugerencia_CiudadanaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> _Queja_Sugerencia_CiudadanaRepository;
        #endregion

        #region Ctor
        public Queja_Sugerencia_CiudadanaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> Queja_Sugerencia_CiudadanaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Queja_Sugerencia_CiudadanaRepository = Queja_Sugerencia_CiudadanaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> SelAll(bool ConRelaciones)
        {
            return this._Queja_Sugerencia_CiudadanaRepository.Table.ToList();
        }

        public IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> SelAllComplete(bool ConRelaciones)
        {
            return this._Queja_Sugerencia_CiudadanaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Queja_Sugerencia_CiudadanaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Queja_Sugerencia_CiudadanaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Queja_Sugerencia_CiudadanaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_CiudadanaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Queja_Sugerencia_CiudadanaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Queja_Sugerencia_CiudadanaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Queja_Sugerencia_CiudadanaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana entity, Spartane.Core.Domain.User.GlobalData Queja_Sugerencia_CiudadanaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana entity, Spartane.Core.Domain.User.GlobalData Queja_Sugerencia_CiudadanaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

