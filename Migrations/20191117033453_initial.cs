using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Leo.ResumeProfile.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResumeUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(maxLength: 255, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTimeOffset>(nullable: false),
                    PlaceOfBirth = table.Column<string>(maxLength: 50, nullable: true),
                    Passport = table.Column<string>(maxLength: 50, nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Email3rd = table.Column<string>(maxLength: 50, nullable: true),
                    EmailPri = table.Column<string>(maxLength: 50, nullable: true),
                    HomeAddressCHN = table.Column<string>(maxLength: 50, nullable: true),
                    HomeAddressJPN = table.Column<string>(maxLength: 50, nullable: true),
                    HomeAddressENG = table.Column<string>(maxLength: 50, nullable: true),
                    MaritalStatus = table.Column<int>(nullable: false),
                    CharactersCHN = table.Column<string>(maxLength: 50, nullable: true),
                    CharactersJPN = table.Column<string>(maxLength: 50, nullable: true),
                    CharactersENG = table.Column<string>(maxLength: 50, nullable: true),
                    WorkHabbitsCHN = table.Column<string>(maxLength: 50, nullable: true),
                    WorkHabbitsJPN = table.Column<string>(maxLength: 50, nullable: true),
                    WorkHabbitsENG = table.Column<string>(maxLength: 50, nullable: true),
                    NameEng = table.Column<string>(maxLength: 50, nullable: true),
                    NameJpn = table.Column<string>(maxLength: 50, nullable: true),
                    NameChn = table.Column<string>(maxLength: 50, nullable: true),
                    ImagePortraitName = table.Column<string>(maxLength: 50, nullable: true),
                    ImageLifeName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ResumeUserId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_ResumeUsers_ResumeUserId",
                        column: x => x.ResumeUserId,
                        principalTable: "ResumeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(nullable: false),
                    Start = table.Column<DateTimeOffset>(nullable: false),
                    End = table.Column<DateTimeOffset>(nullable: false),
                    DurationInYear = table.Column<double>(nullable: false),
                    StudyWorkPlaceNameChn = table.Column<string>(nullable: true),
                    StudyWorkPlaceNameJpn = table.Column<string>(nullable: true),
                    StudyWorkPlaceNameEng = table.Column<string>(nullable: true),
                    DesignationDegreeChn = table.Column<string>(nullable: true),
                    DesignationDegreeJpn = table.Column<string>(nullable: true),
                    DesignationDegreeEng = table.Column<string>(nullable: true),
                    StudyWorkRole = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    ResumeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experience_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Experience_ResumeUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ResumeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceSummary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(nullable: true),
                    ContentChn = table.Column<string>(nullable: true),
                    ContentJpn = table.Column<string>(nullable: true),
                    ContentEng = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    ResumeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceSummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperienceSummary_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExperienceSummary_ResumeUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ResumeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true),
                    Item = table.Column<string>(nullable: true),
                    DurationHandWrite = table.Column<float>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    PersonalFocusPriority = table.Column<int>(nullable: false),
                    ExperienceDesc = table.Column<string>(nullable: true),
                    TargetDesc = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    ResumeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skill_ResumeUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ResumeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true),
                    ObtainedDate = table.Column<DateTimeOffset>(nullable: false),
                    CertOrganizationNameChn = table.Column<string>(nullable: true),
                    CertOrganizationNameJpn = table.Column<string>(nullable: true),
                    CertOrganizationNameEng = table.Column<string>(nullable: true),
                    DesignationDegreeChn = table.Column<string>(nullable: true),
                    DesignationDegreeJpn = table.Column<string>(nullable: true),
                    DesignationDegreeEng = table.Column<string>(nullable: true),
                    StudyWorkContentDescChn = table.Column<string>(nullable: true),
                    StudyWorkContentDescJpn = table.Column<string>(nullable: true),
                    StudyWorkContentDescEng = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    SkillId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificate_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Certificate_ResumeUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ResumeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Organization = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Keyword = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Start = table.Column<DateTimeOffset>(nullable: false),
                    End = table.Column<DateTimeOffset>(nullable: false),
                    Client = table.Column<string>(nullable: true),
                    OperatingSystem = table.Column<string>(nullable: true),
                    Tools = table.Column<string>(nullable: true),
                    TeamSize = table.Column<int>(nullable: false),
                    RoleNameChn = table.Column<string>(nullable: true),
                    RoleNameJpn = table.Column<string>(nullable: true),
                    RoleNameEng = table.Column<string>(nullable: true),
                    SkillsId = table.Column<int>(nullable: true),
                    ProjectObjectiveChn = table.Column<string>(nullable: true),
                    ProjectObjectiveJpn = table.Column<string>(nullable: true),
                    ProjectObjectiveEng = table.Column<string>(nullable: true),
                    ProjectDescriptionChn = table.Column<string>(nullable: true),
                    ProjectDescriptionJpn = table.Column<string>(nullable: true),
                    ProjectDescriptionEng = table.Column<string>(nullable: true),
                    RoleAndResponsibilityChn = table.Column<string>(nullable: true),
                    RoleAndResponsibilityJpn = table.Column<string>(nullable: true),
                    RoleAndResponsibilityEng = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    ResumeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDetail_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectDetail_Skill_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectDetail_ResumeUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ResumeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "URL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true),
                    UrlAddress = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SkillId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_URL_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ResumeUsers",
                columns: new[] { "Id", "CharactersCHN", "CharactersENG", "CharactersJPN", "Comment", "DateOfBirth", "Email3rd", "EmailPri", "Gender", "HomeAddressCHN", "HomeAddressENG", "HomeAddressJPN", "ImageLifeName", "ImagePortraitName", "MaritalStatus", "MobileNo", "NameChn", "NameEng", "NameJpn", "Passport", "PlaceOfBirth", "WorkHabbitsCHN", "WorkHabbitsENG", "WorkHabbitsJPN" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), null, null, null, null, new DateTimeOffset(new DateTime(1650, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 5, 0, 0)), null, null, 0, null, null, null, null, null, 0, "Ships", "林佳伟", "Leo Lin", "林佳偉", "Berry", "Griffin Beak Eldritch", null, null, null },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), null, null, null, null, new DateTimeOffset(new DateTime(1668, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 5, 0, 0)), null, null, 0, null, null, null, null, null, 0, "Rum", "林佳伟2", "Leo Lin2", "林佳偉2", "Nancy", "Swashbuckler Rye", null, null, null },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), null, null, null, null, new DateTimeOffset(new DateTime(1701, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 5, 0, 0)), null, null, 0, null, null, null, null, null, 0, "Singing", "林佳伟3", "Leo Lin3", "林佳偉3", "Eli", "Ivory Bones Sweet", null, null, null },
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), null, null, null, null, new DateTimeOffset(new DateTime(1702, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 5, 0, 0)), null, null, 0, null, null, null, null, null, 0, "Singing", "林佳伟4", "Leo Lin4", "林佳偉4", "Arnold", "The Unseen Stafford", null, null, null },
                    { new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"), null, null, null, null, new DateTimeOffset(new DateTime(1690, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 5, 0, 0)), null, null, 0, null, null, null, null, null, 0, "Maps", "林佳伟5", "Leo Lin5", "林佳偉5", "Seabury", "Toxic Reyson", null, null, null },
                    { new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"), null, null, null, null, new DateTimeOffset(new DateTime(1723, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 5, 0, 0)), null, null, 0, null, null, null, null, null, 0, "General debauchery", "林佳伟6", "Leo Lin6", "林佳偉6", "Rutherford", "Fearless Cloven", null, null, null },
                    { new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"), null, null, null, null, new DateTimeOffset(new DateTime(1721, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 5, 0, 0)), null, null, 0, null, null, null, null, null, 0, "Rum", "林佳伟7", "Leo Lin7", "林佳偉7", "Atherton", "Crow Ridley", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Resumes",
                columns: new[] { "Id", "Description", "ResumeUserId", "Title" },
                values: new object[,]
                {
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In this course you'll learn how to sail away and avoid those pesky musketeers.", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Commandeering a Ship Without Getting Caught" },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "In this course, the ResumeUser provides tips to avoid, or, if needed, overthrow pirate mutiny.", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Overthrowing Mutiny" },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "Every good pirate loves rum, but it also has a tendency to get you into trouble.  In this course you'll learn how to avoid that.  This new exclusive edition includes an additional chapter on how to run fast without falling while drunk.", new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Avoiding Brawls While Drinking as Much Rum as You Desire" },
                    { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), "In this course you'll learn how to sing all-time favourite pirate songs without sounding like you actually know the words or how to hold a note.", new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "Singalong Pirate Hits" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificate_SkillId",
                table: "Certificate",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificate_UserId",
                table: "Certificate",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_ResumeId",
                table: "Experience",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_UserId",
                table: "Experience",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSummary_ResumeId",
                table: "ExperienceSummary",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSummary_UserId",
                table: "ExperienceSummary",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetail_ResumeId",
                table: "ProjectDetail",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetail_SkillsId",
                table: "ProjectDetail",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetail_UserId",
                table: "ProjectDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_ResumeUserId",
                table: "Resumes",
                column: "ResumeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_ResumeId",
                table: "Skill",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_UserId",
                table: "Skill",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_URL_SkillId",
                table: "URL",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "ExperienceSummary");

            migrationBuilder.DropTable(
                name: "ProjectDetail");

            migrationBuilder.DropTable(
                name: "URL");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "ResumeUsers");
        }
    }
}
