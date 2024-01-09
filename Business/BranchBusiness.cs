using AFS_Visa_Application_REST_API.Data_Contracts.Appointment;
using AFS_Visa_Application_REST_API.Data_Contracts.Branch;
using AFS_Visa_Application_REST_API.Entity;
using AFS_Visa_Application_REST_API.Interfaces.Business;
using AFS_Visa_Application_REST_API.Interfaces.Repository;
using AutoMapper;

namespace AFS_Visa_Application_REST_API.Business
{
    public class BranchBusiness : IBranchBusiness
    {
        private IBranchRepository _branchRepository;
        private IMapper _mapper;

        public BranchBusiness(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }

        public Guid Create(AddEditBranchDto branch)
        {
            var branchEntity = _mapper.Map<Branch>(branch);
            return _branchRepository.Create(branchEntity);
        }

        public List<BranchDto> Get()
        {
            return _mapper.Map<List<BranchDto>>(_branchRepository.Get());
        }

        public BranchDto GetById(Guid id)
        {
            return _mapper.Map<BranchDto>(_branchRepository.GetById(id));
        }

        public Guid Update(AddEditBranchDto branch)
        {
            var branchEntity = _mapper.Map<Branch>(branch);
            return _branchRepository.Update(branchEntity);
        }

        public List<List<DateTime>> GetAppointmentDates(Guid branchId, DateTime departureDate)
        {
            return _branchRepository.GetAppointmentDates(branchId, departureDate);
        }

        public void BookAppointment(AddEditAppointmentDto appointment)
        {
            _branchRepository.BookAppointment(_mapper.Map<Appointment>(appointment));
        }
    }
}
