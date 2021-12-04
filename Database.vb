Imports System.Data.SQLite
Public Class Database
	Dim filename As String = "OceanaClinic.db"
	Dim path As String = "database"
	Dim fullpath As String = System.IO.Path.Combine(path, filename)
	Dim connectionString As String = String.Format("Data Source = {0}", fullpath)
	Dim conn As New SQLiteConnection(connectionString)

	Sub New()
		If Not DatabaseExists(fullpath) Then
			System.IO.Directory.CreateDirectory(path)

			'creating a tale if database doesnt exist (Not [True])
			Dim createUserTableQuery = "
CREATE TABLE ""PatientAllergies"" (
	""ConID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""PatientIC""	TEXT NOT NULL,
	""Allergies""	TEXT NOT NULL
);

CREATE TABLE ""PatientInformation"" (
	""PatientIC""	TEXT NOT NULL UNIQUE,
	""Name""	TEXT,
	""Gender""	TEXT,
	""DoctoreAssigned""	TEXT,
	""CurrentResidence""	TEXT,
	""PhoneNumber""	TEXT,
	""DOB""	TEXT,
	""Weight""	NUMERIC,
	""Height""	NUMERIC,
	""BloodType""	TEXT,
	PRIMARY KEY(""PatientIC"")
);

CREATE TABLE ""PatientTreatment"" (
	""TreatmentID""	TEXT NOT NULL UNIQUE,
	""PatientIC""	TEXT NOT NULL,
	""Date""	TEXT NOT NULL,
	""DoctorUsername""	TEXT NOT NULL,
	""DoctorNote""	TEXT,
	""Total""	REAL,
	""OutStanding""	REAL,
	PRIMARY KEY(""TreatmentID"")
);

CREATE TABLE ""Payment"" (
	""PaymentID""	TEXT NOT NULL,
	""TreatmentID""	TEXT NOT NULL,
	""PtID""	TEXT NOT NULL,
	""PaymentNote""	TEXT,
	""TotalPayed""	REAL,
	""TotalChange"" REAL,
	PRIMARY KEY(""PaymentID"")
);

CREATE TABLE ""PaymentRecord"" (
	""AutoID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""PaymentID""	TEXT NOT NULL,
	""Date""	TEXT NOT NULL,
	""Change"" REAL,
	""AmountPayed""	REAL
);

CREATE TABLE ""PaymentType"" (
	""PtID""	TEXT NOT NULL UNIQUE,
	""Type""	TEXT NOT NULL,
	PRIMARY KEY(""PtID"")
);

CREATE TABLE ""Treatment"" (
	""MSID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""MSName""	TEXT NOT NULL,
	""Fee""	NUMERIC
);

CREATE TABLE ""TreatmentDetails"" (
	""AutoID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""TreatmentID""	TEXT NOT NULL,
	""MSID""	INTEGER NOT NULL
);

CREATE TABLE ""User"" (
	""UserID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""UserType""	TEXT,
	""Username""	TEXT,
	""Password""	TEXT,
	""EmployeeName""	TEXT
);

INSERT INTO PaymentType 
VALUES 
('P01', 'Cash - Full'),
('P02', 'Cash - Installment'),
('P03', 'Cash - Others'),
('P04', 'Cheque'),
('P05', 'Credit card - Full'),
('P06', 'Credit card - Installment'),
('P07', 'Bank Transfer'),
('P08', 'Others');

"
			Dim cmd As New SQLiteCommand(createUserTableQuery, conn)
			conn.Open()
			cmd.ExecuteNonQuery()
			conn.Close()
			'how can they know what to save as as in, i can understand where create the path but where they know what name to save as i dont see filename refered
		End If
	End Sub
	'Checking if Database already exist in the folder path, If exist returns True
	Function DatabaseExists(path As String) As Boolean
		Return System.IO.File.Exists(path)
	End Function

	'Login function return employeename
	Function LoginEmName(username As String, password As String, usertype As String) As String

		Dim loginQuery = "SELECT * FROM User WHERE Username = @1 AND Password = @2 AND UserType = @3"
		Dim cmd As New SQLiteCommand(loginQuery, conn)
		cmd.Parameters.AddWithValue("@1", username)
		cmd.Parameters.AddWithValue("@2", password)
		cmd.Parameters.AddWithValue("@3", usertype)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		rdr.Read()
		Dim EmName = rdr.GetValue(4)
		Return EmName
	End Function

	'Login Fuction to return boolean value back to Login.vb 
	Function Login(username As String, password As String, usertype As String) As Boolean

		Dim loginQuery = "SELECT * FROM User WHERE Username = @1 AND Password = @2 AND UserType = @3"
		Dim cmd As New SQLiteCommand(loginQuery, conn)
		cmd.Parameters.AddWithValue("@1", username)
		cmd.Parameters.AddWithValue("@2", password)
		cmd.Parameters.AddWithValue("@3", usertype)
		conn.Open()
		Dim userObj = cmd.ExecuteScalar()
		conn.Close()
		If userObj Is Nothing Then
			Return False
		Else
			Return True
		End If
	End Function
	'Inserting data for Register.vb into Database 
	Sub AddUsers(usertype As String, username As String, password As String, emname As String)

		Dim AddUserQuery = "INSERT INTO User (UserType, Username, Password, EmployeeName) VALUES (@usertype,@username,@password,@emname)"
		Dim cmd As New SQLiteCommand(AddUserQuery, conn)
		cmd.Parameters.AddWithValue("@usertype", usertype)
		cmd.Parameters.AddWithValue("@username", username)
		cmd.Parameters.AddWithValue("@password", password)
		cmd.Parameters.AddWithValue("@emname", emname)
		conn.Open()
		cmd.ExecuteNonQuery()
		MsgBox("You have sucessfully registered")
		conn.Close()
	End Sub





	''.............................................................. DISPLAY TABLE SECTION ...........................................................................

	'Queries to display database
	'Displaying the view patient table in the application (Nurse) DONE
	Function ViewPatientTable() As DataTable

		Dim ViewPatientQuerry = "SELECT PatientInformation.PatientIC as ""IC Number"", PatientInformation.Name, Gender, DoctoreAssigned as ""Primary Doctor"",CurrentResidence as ""Address"", PhoneNumber as ""PhoneNumber"",DOB as ""Date Of Birth"",Weight,Height, group_concat(Allergies) AS ""Allergies"",BloodType  From PatientInformation LEFT JOIN PatientAllergies ON PatientInformation.PatientIC = PatientAllergies.PatientIC GROUP BY PatientInformation.PatientIC"
		Dim cmd As New SQLiteCommand(ViewPatientQuerry, conn)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function


	'display what types of treatments has patients received         
	Function PatientTreaments() As DataTable
		Dim ViewPatientQuerry = "Select PatientTreatment.TreatmentID, PatientInformation.PatientIC, Name, Date, group_concat(MSName) As ""Treatments Recieved"", DoctorUsername As ""Recieved Treatment From"" , DoctorNote, Total as ""Total Price""  FROM PatientTreatment JOIN TreatmentDetails ON patienttreatment.TreatmentID = TreatmentDetails.treatmentID JOIN Treatment ON TreatmentDetails.MSID = Treatment.MSID JOIN PatientInformation ON PatientTreatment.PatientIC  = PatientInformation.PatientIC GROUP BY PatientTreatment.TreatmentID"
		Dim cmd As New SQLiteCommand(ViewPatientQuerry, conn)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function

	'show list of payable treatment a patient can make (Nurse BIlling) 
	Function PatientOutstanding(ic As String)
		Dim PatientOustanding = "Select PatientTreatment.TreatmentID, PatientInformation.PatientIC, group_concat(MSName) As ""Treatments Recieved"", Total as ""Total Price"", OutStanding as ""Outstanding Payment"", Date FROM PatientTreatment JOIN TreatmentDetails ON patienttreatment.TreatmentID = TreatmentDetails.treatmentID JOIN Treatment ON TreatmentDetails.MSID = Treatment.MSID JOIN PatientInformation ON PatientTreatment.PatientIC  = PatientInformation.PatientIC WHERE Patientinformation.PatientIC = @ic AND OutStanding > 0 GROUP BY PatientTreatment.TreatmentID"
		Dim cmd As New SQLiteCommand(PatientOustanding, conn)
		cmd.Parameters.AddWithValue("@ic", ic)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function


	'show list of doctor 
	Function DoctorComboBox() As List(Of String)
		Dim combobox As New DataTable

		Dim query = "SELECT * FROM User WHERE UserType = 'Doctor'"
		Dim cmd As New SQLiteCommand(query, conn)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim cbo As New List(Of String)
		While rdr.Read()
			cbo.Add(rdr("EmployeeName"))
		End While
		conn.Close()
		Return cbo
	End Function

	'show list of Payment types
	Function PaymentComboBox() As DataTable
		Dim combobox As New DataTable

		Dim query = "SELECT * FROM PaymentType"
		Dim cmd As New SQLiteCommand(query, conn)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function

	'Display List of Treatments and services that can be selected for treating a patient
	Function MS() As DataTable
		Dim ViewMSQuerry = "SELECT MSID, MSName as 'Medicine and Services Type', Fee as 'Price' FROM Treatment"
		Dim cmd As New SQLiteCommand(ViewMSQuerry, conn)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function

	'Display only Patient's Name and Patient IC 
	Function PatientName() As DataTable
		Dim patientnamequery = "SELECT PatientIC , Name FROM PatientInformation"
		Dim cmd As New SQLiteCommand(patientnamequery, conn)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function

	'Display User Table
	Function UserTable() As DataTable
		Dim patientnamequery = "SELECT * FROM User"
		Dim cmd As New SQLiteCommand(patientnamequery, conn)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function

	'Display Payment records table
	Function PaymentRecordTable() As DataTable
		Dim patientnamequery = "select Payment.PaymentID, payment.TreatmentID, Type, AmountPayed as ""Amount Paid"", Change as ""Change"", Date, TotalPayed as ""Total Paid"" from payment join PaymentRecord on payment.PaymentID = PaymentRecord.PaymentID JOIN PaymentType on PaymentType.PtID = payment.PtID"
		Dim cmd As New SQLiteCommand(patientnamequery, conn)
		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function

	''Display Item Price in receipt
	Function ReceiptMSfee(treatmentname As String) As String
		Dim query = "SELECT Fee FROM Treatment WHERE MSName = @1"
		Dim cmd As New SQLiteCommand(query, conn)
		cmd.Parameters.AddWithValue("@1", treatmentname)
		conn.Open()
		Dim MSfee As String = ""

		Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

		While rdr.Read
			MSfee = rdr(0)
		End While
		conn.Close()
		Return MSfee
	End Function




	''.............................................................. ADD DATA SECTION ...........................................................................
	'Sub codes to enter data into the database

	'inserting a new patient's information
	Sub AddPatientInformation(ic As String, name As String, gender As String, doctorassigned As String, address As String, phone As String, dob As String, weight As String, height As String, bloodtype As String, allergy As ListBox.ObjectCollection)
		Dim AddPatientQuery = "INSERT INTO PatientInformation VALUES (@ic,@name,@gender,@doctor,@address,@phone,@dob,@weight,@height,@bloodtype)"
		Dim AddAllegiesQuery = "INSERT INTO PatientAllergies (PatientIC, Allergies) VALUES (@ic, @allergy)"
		Dim cmd As New SQLiteCommand(AddPatientQuery, conn)
		Dim sqlcmd As New SQLiteCommand(AddAllegiesQuery, conn)
		cmd.Parameters.AddWithValue("@ic", ic)
		cmd.Parameters.AddWithValue("@name", name)
		cmd.Parameters.AddWithValue("@gender", gender)
		cmd.Parameters.AddWithValue("@doctor", doctorassigned)
		cmd.Parameters.AddWithValue("@address", address)
		cmd.Parameters.AddWithValue("@phone", phone)
		cmd.Parameters.AddWithValue("@dob", dob)
		cmd.Parameters.AddWithValue("@weight", weight)
		cmd.Parameters.AddWithValue("@height", height)
		cmd.Parameters.AddWithValue("@bloodtype", bloodtype)
		cmd.Parameters.AddWithValue("@allergy", allergy)

		conn.Open()
		cmd.ExecuteNonQuery() 'added in main data in patientinformation

		For Each item As String In allergy 'adding data of patient's allergies into the allergy table

			sqlcmd.Parameters.AddWithValue("@ic", ic)
			sqlcmd.Parameters.AddWithValue("@allergy", item)

			sqlcmd.ExecuteNonQuery()
		Next

		MsgBox("You have sucessfully added a patient information.")
		conn.Close()
	End Sub

	'inserting new treatment types
	Sub NewTreatment(msname As String, fee As String)
		Dim AddNewTreatment = "INSERT INTO Treatment (MSName, Fee) VALUES (@MSName, @Fee)"

		Dim cmd As New SQLiteCommand(AddNewTreatment, conn)
		'cmd.Parameters.AddWithValue("@MSName", msname)
		cmd.Parameters.AddWithValue("@Fee", fee)
		cmd.Parameters.AddWithValue("@MSName", msname)

		conn.Open()
		cmd.ExecuteNonQuery()
		MessageBox.Show("You have successfully added a new type of treatment!", "Doctor")
		conn.Close()
	End Sub

	'inserting a patient to recieve a treatment (Doctor)
	Sub AddPatientTreatment(treatmentid As String, ic As String, datetreated As String, doctor As String, note As String, msid As List(Of String))
		Dim PatientTreatmentQuery = "INSERT INTO PatientTreatment (TreatmentID, PatientIC, Date, DoctorUsername, DoctorNote) VALUES (@treatmentid,@patientic,@date,@doctorusername,@doctornote);"
		Dim TreatmentDetailsQuery = "INSERT INTO TreatmentDetails (TreatmentID, MSID) VALUES (@TreatmentID,@MSID)"
		Dim UpdateTotal = "update patienttreatment SET total = (select sum(fee) + 30 from treatmentdetails join treatment on treatmentdetails.Msid = treatment.msid WHERE TreatmentDetails.TreatmentID = PatientTreatment.TreatmentID) WHERE PatientTreatment.TreatmentID = @treatmentid;
							update PatientTreatment set OutStanding = total where OutStanding is NULL;"
		Dim checkunique = "SELECT * FROM PatientTreatment WHERE TreatmentID = @treatmentid"
		conn.Open()
		Dim chkcmd As New SQLiteCommand(checkunique, conn)
		chkcmd.Parameters.AddWithValue("@treatmentid", treatmentid)
		Dim chk = chkcmd.ExecuteScalar()

		If chk Is Nothing Then


			Dim cmd As New SQLiteCommand(PatientTreatmentQuery, conn)
			Dim sqlcmd As New SQLiteCommand(TreatmentDetailsQuery, conn)
			Dim updatecmd As New SQLiteCommand(UpdateTotal, conn)

			cmd.Parameters.AddWithValue("@treatmentid", treatmentid)
			cmd.Parameters.AddWithValue("@patientic", ic)
			cmd.Parameters.AddWithValue("@date", datetreated)
			cmd.Parameters.AddWithValue("@doctorusername", doctor)
			cmd.Parameters.AddWithValue("@doctornote", note)
			cmd.ExecuteNonQuery()

			For Each item As String In msid

				sqlcmd.Parameters.AddWithValue("@MSID", item)
				sqlcmd.Parameters.AddWithValue("@TreatmentID", treatmentid)

				sqlcmd.ExecuteNonQuery()

			Next

			updatecmd.Parameters.AddWithValue("@treatmentid", treatmentid)
			updatecmd.ExecuteNonQuery()
			MessageBox.Show("You have sucessfully added a patient's treatment details!", "Add Patient Treament")
			conn.Close()
		Else
			MsgBox("TreatmentID already exist")
			conn.Close()
		End If

	End Sub

	'creating an auto id for treatmentID to be added to PatientTreatment
	Function TreatmentAutoID() As String
		Dim digit As Integer
		Dim cmd As New SQLiteCommand("SELECT Max(TreatmentID) FROM PatientTreatment", conn)
		conn.Open()
		Dim Resultsnumber = cmd.ExecuteScalar().ToString()
		conn.Close()

		If String.IsNullOrEmpty(Resultsnumber) Then
			Resultsnumber = "T000000"
		End If

		Resultsnumber = Resultsnumber.Substring(5)
		Int32.TryParse(Resultsnumber, digit)
		digit = digit + 1
		Resultsnumber = "T" + digit.ToString("D6")
		Return Resultsnumber
	End Function

	'Administrator add new Users
	Sub NewUser(usertype As String, username As String, password As String, emname As String)
		Dim newuserquery = "INSERT INTO User (UserType,Username,Password,EmployeeName) VALUES (@usertype,@username,@password,@emname)"
		Dim cmd As New SQLiteCommand(newuserquery, conn)

		cmd.Parameters.AddWithValue("@usertype", usertype)
		cmd.Parameters.AddWithValue("@username", username)
		cmd.Parameters.AddWithValue("@password", password)
		cmd.Parameters.AddWithValue("@emname", emname)

		conn.Open()
		cmd.ExecuteNonQuery()
		conn.Close()

		MessageBox.Show("You have sucessfully added a new user!", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)

	End Sub

	'Add New Payment for Nurse Billing
	Sub NewPayment(paymentid As String, treatmentid As String, ptid As String, note As String, paymentdate As String, amountpayed As Double, change As Double)

		Dim ExistQuery = "SELECT * FROM Payment WHERE TreatmentID = @treatmentid"
		Dim cmd As New SQLiteCommand(ExistQuery, conn)
		cmd.Parameters.AddWithValue("@treatmentid", treatmentid)
		conn.Open()
		Dim userObj = cmd.ExecuteScalar()
		If userObj = Nothing Then

			Dim NewPaymentQuery = "INSERT INTO Payment (PaymentID, TreatmentID, PtID, PaymentNote) VALUES (@paymentid,@treatmentid,@ptid,@note)"
			Dim NewPaymentDetailsQuery = "INSERT INTO PaymentRecord (PaymentID,Date,AmountPayed,Change) VALUES (@id, @date, @payed,@change)"
			Dim paymentcmd As New SQLiteCommand(NewPaymentQuery, conn)
			Dim detailscmd As New SQLiteCommand(NewPaymentDetailsQuery, conn)

			paymentcmd.Parameters.AddWithValue("@paymentid", paymentid)
			paymentcmd.Parameters.AddWithValue("@treatmentid", treatmentid)
			paymentcmd.Parameters.AddWithValue("@ptid", ptid)
			paymentcmd.Parameters.AddWithValue("@note", note)

			detailscmd.Parameters.AddWithValue("@id", paymentid)
			detailscmd.Parameters.AddWithValue("@date", paymentdate)
			detailscmd.Parameters.AddWithValue("@payed", amountpayed)
			detailscmd.Parameters.AddWithValue("@change", change)

			paymentcmd.ExecuteNonQuery()
			detailscmd.ExecuteNonQuery()

			MessageBox.Show("You have sucessfully added a new Payment!", "Nurse", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else

			Dim AddPaymentRecordsQuery = "INSERT INTO PaymentRecord (PaymentID,Date,AmountPayed,Change) VALUES (@id, @date, @payed,@change) "
			Dim PaymentRecordcmd As New SQLiteCommand(AddPaymentRecordsQuery, conn)

			PaymentRecordcmd.Parameters.AddWithValue("@id", userObj)
			PaymentRecordcmd.Parameters.AddWithValue("@date", paymentdate)
			PaymentRecordcmd.Parameters.AddWithValue("@payed", amountpayed)
			PaymentRecordcmd.Parameters.AddWithValue("@change", change)

			PaymentRecordcmd.ExecuteNonQuery()

			MessageBox.Show("You have sucessfully updated patient's payment!", "Nurse", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If

		Dim Updatequery = "UPDATE Payment SET TotalPayed = (SELECT sum(AmountPayed) FROM PaymentRecord WHERE Payment.paymentid = paymentrecord.paymentid);
							UPDATE Payment SET TotalChange = (SELECT sum(Change) FROM PaymentRecord WHERE Payment.paymentid = paymentrecord.paymentid);
							UPDATE PatientTreatment SET OutStanding = PatientTreatment.Total + (SELECT TotalChange FROM Payment where Payment.TreatmentID = PatientTreatment.TreatmentID) - (SELECT TotalPayed FROM Payment where Payment.TreatmentID = PatientTreatment.TreatmentID);
							update PatientTreatment set OutStanding = total where OutStanding is NULL;"
		Dim Updatecmd As New SQLiteCommand(Updatequery, conn)
		Updatecmd.ExecuteNonQuery()

		conn.Close()
	End Sub

	'creating an auto id paymentID to be added to PatientTreatment
	Function PaymentAutoID() As String
		Dim digit As Integer
		Dim cmd As New SQLiteCommand("SELECT Max(PaymentID) FROM Payment", conn)
		conn.Open()
		Dim Resultsnumber = cmd.ExecuteScalar().ToString()
		conn.Close()

		If String.IsNullOrEmpty(Resultsnumber) Then
			Resultsnumber = "P000000"
		End If

		Resultsnumber = Resultsnumber.Substring(1)
		Int32.TryParse(Resultsnumber, digit)
		digit = digit + 1
		Resultsnumber = "P" + digit.ToString("D6")
		Return Resultsnumber
	End Function





	'........................................................... UPDATE DATA SECTION ..........................................................................................

	'UPDATE PATIENT INFORMATION
	Sub UpdatePatientInformation(ic As String, name As String, gender As String, doctorassigned As String, address As String, phone As String, dob As String, weight As String, height As String, bloodtype As String, allergy As ListBox.ObjectCollection)
		Dim UpdatePatientQuery = "UPDATE PatientInformation SET Name = @name, Gender = @gender, doctoreAssigned = @doctor, CurrentResidence = @address, PhoneNumber = @phone, DOB = @dob, Weight = @weight, Height = @height, BloodType = @bloodtype WHERE PatientIC = @ic"
		Dim deleteallergyquery = "DELETE FROM PatientAllergies WHERE PatientIC = @ic"
		Dim UpdateAllegiesQuery = "INSERT INTO PatientAllergies (PatientIC, Allergies) VALUES (@ic, @allergy)"
		Dim delete As New SQLiteCommand(deleteallergyquery, conn)
		Dim cmd As New SQLiteCommand(UpdatePatientQuery, conn)
		Dim sqlcmd As New SQLiteCommand(UpdateAllegiesQuery, conn)
		cmd.Parameters.AddWithValue("@ic", ic)
		cmd.Parameters.AddWithValue("@name", name)
		cmd.Parameters.AddWithValue("@gender", gender)
		cmd.Parameters.AddWithValue("@doctor", doctorassigned)
		cmd.Parameters.AddWithValue("@address", address)
		cmd.Parameters.AddWithValue("@phone", phone)
		cmd.Parameters.AddWithValue("@dob", dob)
		cmd.Parameters.AddWithValue("@weight", weight)
		cmd.Parameters.AddWithValue("@height", height)
		cmd.Parameters.AddWithValue("@bloodtype", bloodtype)
		cmd.Parameters.AddWithValue("@allergy", allergy)
		delete.Parameters.AddWithValue("@ic", ic)

		conn.Open()
		delete.ExecuteNonQuery() 'deleting all allergies first
		cmd.ExecuteNonQuery() 'update in main data in patientinformation

		For Each item As String In allergy 'adding data of patient's allergies into the allergy table

			sqlcmd.Parameters.AddWithValue("@ic", ic)
			sqlcmd.Parameters.AddWithValue("@allergy", item)

			sqlcmd.ExecuteNonQuery()
		Next

		MsgBox("You have sucessfully updated a patient information.")
		conn.Close()
	End Sub

	'Update User password or Employee Name
	Sub UpdateUser(Username As String, password As String, emname As String)
		Dim DeleteQuery = "UPDATE User SET Password = @password, EmployeeName = @emname	WHERE Username = @username"
		Dim cmd As New SQLiteCommand(DeleteQuery, conn)
		cmd.Parameters.AddWithValue("@emname", emname)
		cmd.Parameters.AddWithValue("@password", password)
		cmd.Parameters.AddWithValue("@username", Username)

		conn.Open()
		cmd.ExecuteNonQuery()
		MessageBox.Show("You have successfully updated the patient's informations.")
		conn.Close()

	End Sub

	''.............................................................. DELETE DATA SECTION ..............................................................
	'Delete Patient Information
	Sub DeletePatientInformation(ic As String)
		Dim DeleteQuery = "DELETE FROM PatientInformation WHERE PatientIC = @ic;
							DELETE FROM PatientAllergies WHERE PatientIC = @ic"
		Dim cmd As New SQLiteCommand(DeleteQuery, conn)
		cmd.Parameters.AddWithValue("@ic", ic)

		conn.Open()
		cmd.ExecuteNonQuery()
		MessageBox.Show("You have successfully deleted the patient's informations.")
		conn.Close()

	End Sub

	'Delete Mstype
	Sub DeleteMS(msid As String)
		Dim DeleteQuery = "DELETE FROM Treatment WHERE MSID = @msid"
		Dim cmd As New SQLiteCommand(DeleteQuery, conn)
		cmd.Parameters.AddWithValue("@msid", msid)

		conn.Open()
		cmd.ExecuteNonQuery()
		MessageBox.Show("You have successfully deleted the patient's informations.")
		conn.Close()
	End Sub

	'Delete Users
	Sub DeleteUsers(userid As String)
		Dim DeleteQuery = "DELETE FROM User WHERE UserID = @userid;"
		Dim cmd As New SQLiteCommand(DeleteQuery, conn)
		cmd.Parameters.AddWithValue("@userid", userid)

		conn.Open()
		cmd.ExecuteNonQuery()
		MessageBox.Show("You have successfully deleted the User's informations.")
		conn.Close()

	End Sub

	'..................................................... CHECK BEFORE DATA ENTER TO DATABASE .........................................................
	'check if User Exist
	Function CheckUserExist(username As String) As Boolean

		Dim CheckUserExistQuery = "SELECT * FROM User WHERE Username = @username"
		Dim cmd As New SQLiteCommand(CheckUserExistQuery, conn)
		cmd.Parameters.AddWithValue("@username", username)
		conn.Open()
		Dim chkrow = cmd.ExecuteScalar()
		conn.Close()

		If chkrow Is Nothing Then
			Return False
		Else
			Return True
		End If

	End Function

	'check is a patient with the same patient ic exist
	Function CheckPatientExist(ic As String) As Boolean

		Dim CheckPatientExistQuery = "SELECT * FROM PatientInformation WHERE PatientIC = @ic"
		Dim cmd As New SQLiteCommand(CheckPatientExistQuery, conn)
		cmd.Parameters.AddWithValue("@ic", ic)
		conn.Open()
		Dim chkrow = cmd.ExecuteScalar()
		conn.Close()

		If chkrow Is Nothing Then
			Return False
		Else
			Return True
		End If

	End Function

	'check if a treatment already exist
	Function CheckTreatmentExist(name As String) As Boolean
		Dim CheckTreatmentExistQuery = "SELECT * FROM Treatment WHERE MSName = @name"
		Dim cmd As New SQLiteCommand(CheckTreatmentExistQuery, conn)
		cmd.Parameters.AddWithValue("@name", name)
		conn.Open()
		Dim chkrow = cmd.ExecuteScalar()
		conn.Close()

		If chkrow Is Nothing Then
			Return False
		Else
			Return True
		End If
	End Function



	'...................................................... SEARCH BAR ...................................................................
	'search in the patient information table
	Function SearchViewPatientTreatment(search As String) As DataTable
		Dim searchQuery = "Select PatientTreatment.TreatmentID, PatientInformation.PatientIC, Name, Date, group_concat(MSName) As ""Treatments Recieved"", DoctorUsername As ""Recieved Treatment From"" , DoctorNote, Total as ""Total Price""  FROM PatientTreatment 
			JOIN TreatmentDetails ON patienttreatment.TreatmentID = TreatmentDetails.treatmentID 
			JOIN Treatment ON TreatmentDetails.MSID = Treatment.MSID 
			JOIN PatientInformation ON PatientTreatment.PatientIC  = PatientInformation.PatientIC 
			WHERE PatientInformation.PatientIC = @1search OR PatientTreatment.TreatmentID = @1search OR Name LIKE @search OR Date LIKE @search OR MSName LIKE @search OR DoctorUsername LIKE @search OR Total LIKE @search 
			GROUP BY PatientTreatment.TreatmentID"

		Dim cmd As New SQLiteCommand(searchQuery, conn)
		cmd.Parameters.AddWithValue("@search", "%" & search & "%")
		cmd.Parameters.AddWithValue("@1search", search)

		conn.Open()
		Dim rdr As SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function

	'search in treat patient tab
	Function SearchPatientSidePart(search As String) As DataTable
		Dim searchquery = "SELECT PatientIC, Name FROM PatientInformation WHERE PatientIC = @1search Or Name Like @search"

		Dim cmd As New SQLiteCommand(searchquery, conn)
		cmd.Parameters.AddWithValue("@search", "%" & search & "%")
		cmd.Parameters.AddWithValue("@1search", search)

		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function

	'search in the patient information tab
	Function SearchViewPatientInformation(search As String) As DataTable
		Dim searchquery = "SELECT PatientInformation.PatientIC as ""IC Number"", PatientInformation.Name, Gender, DoctoreAssigned As ""Primary Doctor"",CurrentResidence As ""Address"", PhoneNumber As ""Phone Number"",DOB As ""Date Of Birth"",Weight,Height, group_concat(Allergies) As ""Allergies"",BloodType  From PatientInformation LEFT JOIN PatientAllergies On PatientInformation.PatientIC = PatientAllergies.PatientIC
							WHERE PatientInformation.PatientIC = @1search Or Name Like @search Or DoctoreAssigned Like @search Or CurrentResidence Like @search Or Allergies Like @search
							GROUP BY PatientInformation.PatientIC"
		Dim cmd As New SQLiteCommand(searchquery, conn)
		cmd.Parameters.AddWithValue("@search", "%" & search & "%")
		cmd.Parameters.AddWithValue("@1search", search)

		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function

	'search Payment record table
	Function SearchPaymentRecordTable(search As String) As DataTable
		Dim patientnamequery = "select Payment.PaymentID, payment.TreatmentID, Type, AmountPayed as ""Amount Paid"", Change as ""Change"", Date, TotalPayed as ""Total Paid"" from payment join PaymentRecord on payment.PaymentID = PaymentRecord.PaymentID JOIN PaymentType on PaymentType.PtID = payment.PtID
								WHERE Payment.PaymentID = @search OR Payment.TreatmentID = @search OR Date = @search OR PaymentType.Type LIKE @1search "
		Dim cmd As New SQLiteCommand(patientnamequery, conn)
		cmd.Parameters.AddWithValue("@search", search)
		cmd.Parameters.AddWithValue("@1search", "%" & search & "%")

		conn.Open()
		Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
		Dim dt As New DataTable
		dt.Load(rdr)
		rdr.Close()
		conn.Close()
		Return dt
	End Function
End Class
