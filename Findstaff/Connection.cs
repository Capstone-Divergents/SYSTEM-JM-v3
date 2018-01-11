using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Findstaff
{
    class Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection dbConnection()
        {
            server = "localhost";
            database = "rms";
            uid = "root";
            //password = "anterograde";
            password = "rootpass";
            //password = "camilo";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            //USE QUIZ1;

            //DROP DATABASE RMS;

            //CREATE DATABASE RMS;

            //USE RMS;

            //CREATE TABLE GENSKILLS_T(
            //    SKILL_ID    Int auto_increment,
            //    SKILLNAME   VARCHAR(100)NOT NULL,
            //    PRIMARY KEY(SKILL_ID)
            //);

            //CREATE TABLE JOBCATEGORY_T(
            //    CATEGORY_ID Int auto_increment,
            //    CATEGORYNAME    VARCHAR(30),
            //    PRIMARY KEY(CATEGORY_ID)
            //);

            //CREATE TABLE JOBTYPE_T(
            //    JOBTYPE_ID  INT AUTO_INCREMENT,
            //    TYPENAME    VARCHAR(100)NOT NULL,
            //    PRIMARY KEY(JOBTYPE_ID)
            //);

            //CREATE TABLE JOB_T(
            //    JOB_ID  Int auto_increment,
            //    CATEGORY_ID Int,
            //    JOBNAME VARCHAR(30)not null,
            //    JOBTYPE_ID INT,
            //    PRIMARY KEY(JOB_ID),
            //    FOREIGN KEY(CATEGORY_ID)


            //        REFERENCES JOBCATEGORY_T(CATEGORY_ID)


            //        ON DELETE CASCADE,
            //    FOREIGN KEY(JOBTYPE_ID)


            //        REFERENCES JOBTYPE_T(JOBTYPE_ID)


            //        ON DELETE CASCADE
            //);

            //CREATE TABLE GENFEES_T(
            //    FEE_ID  Int auto_increment,
            //    FEENAME VARCHAR(30)NOT NULL,
            //    PRIMARY KEY(FEE_ID)
            //);

            //CREATE TABLE FEETYPE_T(
            //    FEE_ID INT,
            //    JOBTYPE_ID INT,
            //    FOREIGN KEY(FEE_ID)


            //        REFERENCES GENFEES_T(FEE_ID)


            //        ON DELETE CASCADE,
            //    FOREIGN KEY(JOBTYPE_ID)


            //        REFERENCES JOBTYPE_T(JOBTYPE_ID)


            //        ON DELETE CASCADE
            //);

            //CREATE TABLE GENREQS_T(
            //    REQ_ID  Int auto_increment,
            //    REQNAME VARCHAR(100)NOT NULL,
            //    ALLOCATION  VARCHAR(30)


            //        CHECK(ALLOCATION IN('COUNTRY', 'JOB', 'BASIC', 'PRE-SELECTION', 'PRE-EMPLOYMENT', 'VISA')),
            //    Description varchar(100),
            //    PRIMARY KEY(REQ_ID)
            //);

            //CREATE TABLE COUNTRY_T(
            //    COUNTRY_ID  int auto_increment,
            //    COUNTRYNAME VARCHAR(30)not null,
            //    PRIMARY KEY(COUNTRY_ID)
            //);

            //CREATE TABLE COUNTRYREQS_T(
            //    COUNTRY_ID Int,
            //    REQ_ID Int,
            //    FOREIGN KEY(COUNTRY_ID)


            //        REFERENCES COUNTRY_T(COUNTRY_ID)


            //        On delete cascade,
            //    FOREIGN KEY(REQ_ID)


            //        REFERENCES GENREQS_T(REQ_ID)


            //        on delete cascade
            //);

            //CREATE TABLE EMP_T(
            //    EMP_ID  int auto_increment,
            //    USERNAME    VARCHAR(30) not null,
            //    PASS    VARCHAR(30) not null,
            //    LNAME   VARCHAR(30) not null,
            //    FNAME   VARCHAR(30) not null,
            //    MNAME   VARCHAR(30),
            //    GENDER  CHAR(6)


            //        CHECK(GENDER IN('MALE', 'FEMALE')),
            //    BIRTHDATE   DATE,
            //    ADDRSS  VARCHAR(60),
            //    CONTACT VARCHAR(11),
            //    DEPTNAME    VARCHAR(30) not null


            //        CHECK(DEPTNAME IN('RECRUITMENT', 'DOCUMENTATION', 'MARKETING', 'ACCOUNTING', 'OPERATIONS')),
            //    PRIMARY KEY(EMP_ID)
            //);

            //CREATE TABLE LOGS_T(
            //    LOG_ID  INT auto_increment,
            //    EMP_ID  int,
            //    INTIME  DATETIME,
            //    OUTTIME DATETIME,
            //    PRIMARY KEY(LOG_ID),
            //    FOREIGN KEY(EMP_ID)


            //    REFERENCES EMP_T(EMP_ID)
            //);

            //CREATE TABLE EMPLOYER_T(
            //    EMPLOYER_ID Int auto_increment,
            //    EMPLOYERNAME    VARCHAR(100) not null,
            //    FOREIGNPRIN VARCHAR(100) NOT NULL,
            //    EMAIL   VARCHAR(100),
            //    CONTACT VARCHAR(30),
            //    COMPANYADD  VARCHAR(100),
            //    COUNTRY_ID  int,
            //    PRIMARY KEY(EMPLOYER_ID),
            //    FOREIGN KEY(COUNTRY_ID)


            //    REFERENCES COUNTRY_T(COUNTRY_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE APP_T(
            //    APP_ID CHAR(10) NOT NULL,
            //    LNAME  VARCHAR(30) not null,
            //    FNAME VARCHAR(30) not null,
            //    MNAME VARCHAR(30),
            //    POSITION    VARCHAR(30),
            //    GENDER CHAR(6),
            //        CHECK(GENDER IN('MALE', 'FEMALE')),
            //    CIVILSTAT   VARCHAR(30)


            //        CHECK(CIVILSTAT IN('SINGLE', 'MARRIED', 'WIDOWED', 'SEPARATED')),
            //    CONTACT VARCHAR(30) not null,
            //    CITIZENSHIP VARCHAR(60) not null,
            //    BIRTHDATE DATE not null,
            //    AGE INT,
            //    AHEIGHT VARCHAR(10),
            //    AWEIGHT VARCHAR(10),
            //    APPSTATUS   VARCHAR(50)


            //        CHECK(APPSTATUS IN('For Selection', 'For Initial Interview', 'For Final Interview', 'Selected', 'Payment', 'Deployed', 'Archived')),
            //    PRIMARY KEY(APP_ID)
            //);

            //CREATE TABLE APPADDRESS_T(
            //    APP_ID  CHAR(10) NOT NULL,
            //    ADDRSS  VARCHAR(100)NOT NULL,
            //    ADDCAT  VARCHAR(10)NOT NULL


            //        CHECK(ADDCAT IN('CURRENT', 'PROVINCIAL')),
            //    PHONENUM1 VARCHAR(30),
            //    PHONENUM2 VARCHAR(30),
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE APPSCHOOL_T(
            //    APP_ID  CHAR(10) NOT NULL,
            //    SCHOOLNAME  VARCHAR(100) NOT NULL,
            //    SCHOOLTYPE  VARCHAR(30) NOT NULL


            //        CHECK(SCHOOLTYPE IN('ELEMENTARY', 'HIGH SCHOOL', 'COLLEGE')),
            //    YRSTART YEAR NOT NULL,
            //    YREND YEAR NOT NULL,
            //    DEGREE  VARCHAR(100),
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE APPSKILLS_T(
            //    APP_ID CHAR(10) NOT NULL,
            //    SKILL_ID int,
            //    PROFICIENCY INT NOT NULL


            //        CHECK(PROFICIENCY IN('1', '2', '3', '4', '5')),
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(SKILL_ID)


            //    REFERENCES GENSKILLS_T(SKILL_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(SKILL_ID)


            //    REFERENCES GENSKILLS_T(SKILL_ID)


            //    ON UPDATE CASCADE
            //);

            //CREATE TABLE APPWORKEX_T(
            //    APP_ID CHAR(10) NOT NULL,
            //    COMPANY VARCHAR(100) NOT NULL,
            //    COMPANYADD VARCHAR(100) NOT NULL,
            //    POSITION VARCHAR(100) NOT NULL,
            //    MONTHSTART  VARCHAR(10) NOT NULL,
            //    YEARSTART   YEAR NOT NULL,
            //    MONTHEND    VARCHAR(10) NOT NULL,
            //    YEAREND YEAR NOT NULL,
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE APPPERSONAL_T(
            //    APP_ID  CHAR(10) NOT NULL,
            //    NAMEOFFATHER    VARCHAR(100),
            //    FAGE    varchar(30),
            //    FOCCUPATION varchar(100),
            //    NAMEOFMOTHER    VARCHAR(100),
            //    MAGE    VARCHAR(30),
            //    MOCCUPATION varchar(100),
            //    NAMEOFSPOUSE    varchar(100),
            //    SAGE    VARCHAR(30),
            //    SOCCUPATION VARCHAR(100),
            //    PRIMARY KEY(APP_ID),
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE APPCHILDREN_T(
            //    APP_ID  CHAR(10) NOT NULL,
            //    CHILDNAME   VARCHAR(100),
            //    AGE INT,
            //    BIRTHDATE   DATE,
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE APPCONTACT_T(
            //    APP_ID  CHAR(10) NOT NULL,
            //    CONTACTNAME VARCHAR(100),
            //    CONTACTNUM  VARCHAR(30),
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE JOBORDER_T(
            //    JORDER_ID   int auto_increment,
            //    EMPLOYER_ID int,
            //    CATEGORY_ID int,
            //    JOB_ID  int,
            //    REQAPP INT,
            //    SALARY  INT,
            //    GENDER  VARCHAR(30)


            //        CHECK(GENDER IN('MALE', 'FEMALE', 'ALL')),
            //    HEIGHTREQ   VARCHAR(10),
            //    WEIGHTREQ   VARCHAR(10),
            //    CNTRCTSTART DATE,
            //    CNTRCTEND DATE,
            //    CNTRCTSTAT  VARCHAR(30)


            //        CHECK(CNTRCTSTAT IN('ACTIVE', 'EXPIRED', 'RENEWED')),
            //    PRIMARY KEY(JORDER_ID),
            //    FOREIGN KEY(CATEGORY_ID, JOB_ID)


            //    REFERENCES JOB_T(CATEGORY_ID, JOB_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(EMPLOYER_ID)


            //    REFERENCES EMPLOYER_T(EMPLOYER_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE JOBDOCS_T(
            //    JORDER_ID   INT,
            //    EMPLOYER_ID Int,
            //    CATEGORY_ID int,
            //    JOB_ID  int,
            //    REQ_ID  int,
            //    FOREIGN KEY(JORDER_ID)


            //    REFERENCES JOBORDER_T(JORDER_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(EMPLOYER_ID)


            //    REFERENCES EMPLOYER_T(EMPLOYER_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(CATEGORY_ID, JOB_ID)


            //    REFERENCES JOB_T(CATEGORY_ID, JOB_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(REQ_ID)


            //    REFERENCES GENREQS_T(REQ_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE JOBSKILLS_T(
            //    JORDER_ID   INT,
            //    EMPLOYER_ID int,
            //    CATEGORY_ID int,
            //    JOB_ID  int,
            //    SKILL_ID    int,
            //    PROFLEVEL   INT


            //        CHECK(PROFLEVEL IN('1', '2', '3', '4', '5')),
            //    FOREIGN KEY(JORDER_ID)


            //    REFERENCES JOBORDER_T(JORDER_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(EMPLOYER_ID)


            //    REFERENCES EMPLOYER_T(EMPLOYER_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(CATEGORY_ID, JOB_ID)


            //    REFERENCES JOB_T(CATEGORY_ID, JOB_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(SKILL_ID)


            //    REFERENCES GENSKILLS_T(SKILL_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE APPLICATIONS_T(
            //    APP_NO  CHAR(10) NOT NULL,
            //    APP_ID  CHAR(10) NOT NULL,
            //    JORDER_ID   INT,
            //    EMPLOYER_ID int,
            //    CATEGORY_ID int,
            //    JOB_ID  int,
            //    INITINTERVIEWDATE   DATE,
            //    INITINTERVIEWSTATUS VARCHAR(10)


            //        CHECK(INTERVIEWSTATUS IN('PASSED', 'FAILED')),
            //    MEDSTAT1    VARCHAR(30)


            //        CHECK(MEDSTAT1 IN('FIT TO WORK', 'UNFIT TO WORK')),
            //    FINALINTERVIEWSTATUS    VARCHAR(10)


            //        CHECK(INTERVIEWSTATUS IN('PASSED', 'FAILED')),
            //    MEDSTAT2    VARCHAR(30)


            //        CHECK(MEDSTAT2 IN('FIT TO WORK', 'UNFIT TO WORK')),
            //    APPSTATS    VARCHAR(30)


            //        CHECK(APPSTATS IN('Active', 'Inactive')),
            //    PRIMARY KEY(APP_NO),
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(JORDER_ID)


            //    REFERENCES JOBORDER_T(JORDER_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(EMPLOYER_ID)


            //    REFERENCES EMPLOYER_T(EMPLOYER_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(CATEGORY_ID, JOB_ID)


            //    REFERENCES JOB_T(CATEGORY_ID, JOB_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE APPDOC_T(
            //    APP_NO  CHAR(10)NOT NULL,
            //    APP_ID CHAR(10)NOT NULL,
            //    REQ_ID int,
            //    DOCSTAT VARCHAR(30)


            //        CHECK(APPSTAT IN('REQUIRED', 'PASSED')),
            //    FOREIGN KEY(APP_NO)


            //    REFERENCES APPLICATIONS_T(APP_NO)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(REQ_ID)


            //    REFERENCES GENREQS_T(REQ_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE JOBFEES_T(
            //    JORDER_ID INT,
            //    EMPLOYER_ID int,
            //    FEE_ID  int,
            //    AMOUNT INT,
            //    PAIDBY VARCHAR(30)


            //        CHECK(PAIDBY IN('EMPLOYER', 'APPLICANT')),
            //    PRIMARY KEY(JORDER_ID, EMPLOYER_ID, FEE_ID),
            //    FOREIGN KEY(JORDER_ID)


            //    REFERENCES JOBORDER_T(JORDER_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(EMPLOYER_ID)


            //    REFERENCES EMPLOYER_T(EMPLOYER_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(FEE_ID)


            //    REFERENCES GENFEES_T(FEE_ID)


            //    ON DELETE CASCADE
            //);

            //CREATE TABLE RECEIPTS_T(
            //    PAY_ID  CHAR(6) NOT NULL,
            //    APP_ID  CHAR(10)NOT NULL,
            //    AMOUNT  INT,
            //    PAYMENT INT,
            //    CHNGE   INT,
            //    RDATE   DATE,
            //    PRIMARY KEY(PAY_ID),
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)
            //);

            //CREATE TABLE PAYABLES_T(
            //    APP_NO  CHAR(10)NOT NULL,
            //    APP_ID  CHAR(10)NOT NULL,
            //    FEE_ID  int,
            //    FEESTATUS   VARCHAR(30)NOT NULL


            //        CHECK(FEESTATUS IN('TO BE PAID', 'PAID')),
            //    DATEPAID    DATE,
            //    PAY_ID CHAR(6),
            //    FOREIGN KEY(APP_NO)


            //    REFERENCES APPLICATIONS_T(APP_NO)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(APP_ID)


            //    REFERENCES APP_T(APP_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(FEE_ID)


            //    REFERENCES GENFEES_T(FEE_ID)


            //    ON DELETE CASCADE,
            //    FOREIGN KEY(PAY_ID)


            //    REFERENCES RECEIPTS_T(PAY_ID)
            //);

            //            INSERT INTO `rms`.`emp_t`
            //(`EMP_ID`,
            //`USERNAME`,
            //`PASS`,
            //`LNAME`,
            //`FNAME`,
            //`MNAME`,
            //`GENDER`,
            //`BIRTHDATE`,
            //`ADDRSS`,
            //`CONTACT`,
            //`DEPTNAME`)
            //VALUES
            //('1',
            //'admin',
            //'admin',
            //'Almojuela',
            //'Danielle Elijah',
            //'Jainar',
            //'Male',
            //'1997-10-12',
            //'Makati City',
            //'09989892720',
            //'Operations');


            connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
