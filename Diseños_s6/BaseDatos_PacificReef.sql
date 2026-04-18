-- Crear las tablas
CREATE TABLE Hotel (hotel_id INT PRIMARY KEY, nombre VARCHAR(100), direccion VARCHAR(200), categoria INT);
CREATE TABLE Cliente (cliente_id VARCHAR(12) PRIMARY KEY, nombre VARCHAR(100), apellido VARCHAR(100), correo_electronico VARCHAR(100), telefono VARCHAR(15));
CREATE TABLE Habitacion (habitacion_id INT PRIMARY KEY, hotel_id INT, tipo VARCHAR(50), capacidad INT, precio DECIMAL(10,2), FOREIGN KEY (hotel_id) REFERENCES Hotel(hotel_id));
CREATE TABLE Reserva (reserva_id INT IDENTITY(1,1) PRIMARY KEY, cliente_id VARCHAR(12), habitacion_id INT, fecha_entrada DATE, fecha_salida DATE, cantidad_personas INT, FOREIGN KEY (cliente_id) REFERENCES Cliente(cliente_id), FOREIGN KEY (habitacion_id) REFERENCES Habitacion(habitacion_id));

-- Insertar los datos base
INSERT INTO Hotel VALUES (1, 'Hotel Pacific Reef', 'Av. Mar 123', 5);
INSERT INTO Cliente VALUES ('11222333-4', 'Juan', 'Perez', 'juan@email.com', '+56912345678');
INSERT INTO Habitacion VALUES (101, 1, 'Matrimonial Vista Mar', 2, 85000.00);
INSERT INTO Reserva (cliente_id, habitacion_id, fecha_entrada, fecha_salida, cantidad_personas) VALUES ('11222333-4', 101, '2026-05-10', '2026-05-15', 2);