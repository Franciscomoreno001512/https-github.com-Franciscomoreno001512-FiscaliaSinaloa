using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Calidad_Migratoria;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Calidad_Migratoria
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Calidad_MigratoriaService : ICalidad_MigratoriaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> _Calidad_MigratoriaRepository;
        #endregion

        #region Ctor
        public Calidad_MigratoriaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> Calidad_MigratoriaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Calidad_MigratoriaRepository = Calidad_MigratoriaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> SelAll(bool ConRelaciones)
        {
            return this._Calidad_MigratoriaRepository.Table.ToList();
        }

        public IList<Core.Domain.Calidad_Migratoria.Calidad_Migratoria> SelAllComplete(bool ConRelaciones)
        {
            return this._Calidad_MigratoriaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Calidad_MigratoriaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Calidad_MigratoriaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Calidad_MigratoriaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Calidad_Migratoria.Calidad_MigratoriaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Calidad_MigratoriaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Calidad_MigratoriaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Calidad_MigratoriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria entity, Spartane.Core.Domain.User.GlobalData Calidad_MigratoriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria entity, Spartane.Core.Domain.User.GlobalData Calidad_MigratoriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

