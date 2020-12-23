using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Datos_de_los_Hechos_PC;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Datos_de_los_Hechos_PC
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Datos_de_los_Hechos_PCService : IDatos_de_los_Hechos_PCService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> _Datos_de_los_Hechos_PCRepository;
        #endregion

        #region Ctor
        public Datos_de_los_Hechos_PCService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> Datos_de_los_Hechos_PCRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Datos_de_los_Hechos_PCRepository = Datos_de_los_Hechos_PCRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> SelAll(bool ConRelaciones)
        {
            return this._Datos_de_los_Hechos_PCRepository.Table.ToList();
        }

        public IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> SelAllComplete(bool ConRelaciones)
        {
            return this._Datos_de_los_Hechos_PCRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Datos_de_los_Hechos_PCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Datos_de_los_Hechos_PCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Datos_de_los_Hechos_PCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Datos_de_los_Hechos_PCPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Datos_de_los_Hechos_PCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Datos_de_los_Hechos_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC entity, Spartane.Core.Domain.User.GlobalData Datos_de_los_Hechos_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC entity, Spartane.Core.Domain.User.GlobalData Datos_de_los_Hechos_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

