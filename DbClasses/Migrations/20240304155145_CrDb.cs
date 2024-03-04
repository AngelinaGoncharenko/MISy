using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbClasses.Migrations
{
    /// <inheritdoc />
    public partial class CrDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Gov",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gov", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Professionaly",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professionaly", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Recept",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dosige = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    format = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recept", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SolutionHosp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionHosp", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TypeEvent",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEvent", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(type: "int", nullable: false),
                    profid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.id);
                    table.ForeignKey(
                        name: "FK_Doctor_Account_accountid",
                        column: x => x.accountid,
                        principalTable: "Account",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Professionaly_profid",
                        column: x => x.profid,
                        principalTable: "Professionaly",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recomendationDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    anamnes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    symptoms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    receptid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.id);
                    table.ForeignKey(
                        name: "FK_Diagnosis_Recept_receptid",
                        column: x => x.receptid,
                        principalTable: "Recept",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedHistory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diagnosid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedHistory", x => x.id);
                    table.ForeignKey(
                        name: "FK_MedHistory_Diagnosis_diagnosid",
                        column: x => x.diagnosid,
                        principalTable: "Diagnosis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last = table.Column<DateTime>(type: "datetime2", nullable: false),
                    next = table.Column<DateTime>(type: "datetime2", nullable: false),
                    doctorid = table.Column<int>(type: "int", nullable: false),
                    ldentitiesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Appointment_Doctor_doctorid",
                        column: x => x.doctorid,
                        principalTable: "Doctor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedCard",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdMC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    photoPatients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appointmentid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedCard", x => x.id);
                    table.ForeignKey(
                        name: "FK_MedCard_Appointment_appointmentid",
                        column: x => x.appointmentid,
                        principalTable: "Appointment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pasport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    genderid = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medCardid = table.Column<int>(type: "int", nullable: false),
                    policy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    снилс = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    govid = table.Column<int>(type: "int", nullable: false),
                    dateEndPolicy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    medHistoryid = table.Column<int>(type: "int", nullable: false),
                    insuranceCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    work = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.id);
                    table.ForeignKey(
                        name: "FK_Patient_Gender_genderid",
                        column: x => x.genderid,
                        principalTable: "Gender",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Gov_govid",
                        column: x => x.govid,
                        principalTable: "Gov",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_MedCard_medCardid",
                        column: x => x.medCardid,
                        principalTable: "MedCard",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_MedHistory_medHistoryid",
                        column: x => x.medHistoryid,
                        principalTable: "MedHistory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hospitalization",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<int>(type: "int", nullable: false),
                    dateBeginHospitalization = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateEndHospitalization = table.Column<DateTime>(type: "datetime2", nullable: false),
                    medHistoryid = table.Column<int>(type: "int", nullable: false),
                    target = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmentid = table.Column<int>(type: "int", nullable: false),
                    conditionsid = table.Column<int>(type: "int", nullable: false),
                    solutionid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitalization", x => x.id);
                    table.ForeignKey(
                        name: "FK_Hospitalization_Conditions_conditionsid",
                        column: x => x.conditionsid,
                        principalTable: "Conditions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitalization_Department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "Department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitalization_MedHistory_medHistoryid",
                        column: x => x.medHistoryid,
                        principalTable: "MedHistory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitalization_Patient_patientid",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitalization_SolutionHosp_solutionid",
                        column: x => x.solutionid,
                        principalTable: "SolutionHosp",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lDEntities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    results = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recomendations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patientid = table.Column<int>(type: "int", nullable: false),
                    doctorid = table.Column<int>(type: "int", nullable: false),
                    typeEventid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lDEntities", x => x.id);
                    table.ForeignKey(
                        name: "FK_lDEntities_Doctor_doctorid",
                        column: x => x.doctorid,
                        principalTable: "Doctor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lDEntities_Patient_patientid",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lDEntities_TypeEvent_typeEventid",
                        column: x => x.typeEventid,
                        principalTable: "TypeEvent",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_doctorid",
                table: "Appointment",
                column: "doctorid");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ldentitiesid",
                table: "Appointment",
                column: "ldentitiesid");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_receptid",
                table: "Diagnosis",
                column: "receptid");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_accountid",
                table: "Doctor",
                column: "accountid");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_profid",
                table: "Doctor",
                column: "profid");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalization_conditionsid",
                table: "Hospitalization",
                column: "conditionsid");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalization_departmentid",
                table: "Hospitalization",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalization_medHistoryid",
                table: "Hospitalization",
                column: "medHistoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalization_patientid",
                table: "Hospitalization",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalization_solutionid",
                table: "Hospitalization",
                column: "solutionid");

            migrationBuilder.CreateIndex(
                name: "IX_lDEntities_doctorid",
                table: "lDEntities",
                column: "doctorid");

            migrationBuilder.CreateIndex(
                name: "IX_lDEntities_patientid",
                table: "lDEntities",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_lDEntities_typeEventid",
                table: "lDEntities",
                column: "typeEventid");

            migrationBuilder.CreateIndex(
                name: "IX_MedCard_appointmentid",
                table: "MedCard",
                column: "appointmentid");

            migrationBuilder.CreateIndex(
                name: "IX_MedHistory_diagnosid",
                table: "MedHistory",
                column: "diagnosid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_genderid",
                table: "Patient",
                column: "genderid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_govid",
                table: "Patient",
                column: "govid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_medCardid",
                table: "Patient",
                column: "medCardid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_medHistoryid",
                table: "Patient",
                column: "medHistoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_lDEntities_ldentitiesid",
                table: "Appointment",
                column: "ldentitiesid",
                principalTable: "lDEntities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Doctor_doctorid",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_lDEntities_Doctor_doctorid",
                table: "lDEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_lDEntities_ldentitiesid",
                table: "Appointment");

            migrationBuilder.DropTable(
                name: "Hospitalization");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "SolutionHosp");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Professionaly");

            migrationBuilder.DropTable(
                name: "lDEntities");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "TypeEvent");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Gov");

            migrationBuilder.DropTable(
                name: "MedCard");

            migrationBuilder.DropTable(
                name: "MedHistory");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "Recept");
        }
    }
}
