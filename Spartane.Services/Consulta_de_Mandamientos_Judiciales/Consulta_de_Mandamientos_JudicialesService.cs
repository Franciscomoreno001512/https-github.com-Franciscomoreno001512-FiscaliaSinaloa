using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Consulta_de_Mandamientos_Judiciales
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Consulta_de_Mandamientos_JudicialesService : IConsulta_de_Mandamientos_JudicialesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> _Consulta_de_Mandamientos_JudicialesRepository;
        #endregion

        #region Ctor
        public Consulta_de_Mandamientos_JudicialesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> Consulta_de_Mandamientos_JudicialesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Consulta_de_Mandamientos_JudicialesRepository = Consulta_de_Mandamientos_JudicialesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> SelAll(bool ConRelaciones)
        {
            return this._Consulta_de_Mandamientos_JudicialesRepository.Table.ToList();
        }

        public IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> SelAllComplete(bool ConRelaciones)
        {
            return this._Consulta_de_Mandamientos_JudicialesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Consulta_de_Mandamientos_JudicialesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Consulta_de_Mandamientos_JudicialesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Consulta_de_Mandamientos_JudicialesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Consulta_de_Mandamientos_JudicialesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Consulta_de_Mandamientos_JudicialesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Consulta_de_Mandamientos_JudicialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales entity, Spartane.Core.Domain.User.GlobalData Consulta_de_Mandamientos_JudicialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales entity, Spartane.Core.Domain.User.GlobalData Consulta_de_Mandamientos_JudicialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

