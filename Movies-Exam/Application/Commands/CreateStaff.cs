using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Commands
{
    public class CreateStaff
    {
        public class Create : IRequest
        {
            public string Name { get; set; }
            public DateTime BornhDate { get; set; }

            public List<Guid> RoleList { get; set; }
            public Guid VisualContentId { get; set; }
        }

        public class CreateValidation : AbstractValidator<Create>
        {
            public CreateValidation()
            {
                RuleFor(x => x.Name).NotEmpty();
                RuleFor(x => x.BornhDate).NotEmpty();
                RuleFor(x => x.RoleList).NotEmpty();
                RuleFor(x => x.VisualContentId).NotEmpty();
            }
        }

        public class Creator : IRequestHandler<Create>
        {
            private readonly MoviesContext _context;

            public Creator(MoviesContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Create request, CancellationToken cancellationToken)
            {
                Guid staffGuid = Guid.NewGuid();
               
                var staff = new Staff
                {
                    StaffId = staffGuid,
                    Name = request.Name,
                    BornhDate = request.BornhDate,
                };

                _context.Staff.Add(staff);

                if(request.RoleList != null && request.VisualContentId != null ) { 

                foreach (var id in request.RoleList)
                {
                    var staffList = new VisualContentStaff
                    {
                        VisualContentId = request.VisualContentId,
                        StaffId = staffGuid,
                        RoleId = id,
                    };
                    _context.VisualContentStaff.Add(staffList);
                }

                }

                var newRole = await _context.SaveChangesAsync();
                if (newRole > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("Can´t Insert New staff member");
            }
        }
    }
}
