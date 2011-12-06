CREATE TABLE "GarminDevices" (
    "id" INTEGER PRIMARY KEY NOT NULL,
    "Name" TEXT NOT NULL
);
CREATE TABLE "Runs" (
    "id" INTEGER PRIMARY KEY AUTOINCREMENT,
    "garmin__device" INTEGER,
    "track_index" INTEGER,
    "first_lap_index" INTEGER,
    "last_lap_index" INTEGER,
    "sport_type" INTEGER,
    "program_type" INTEGER,
    "multi_sport" INTEGER,
    "quick_workout" INTEGER,
    "workout" TEXT,
    "virtual_partner" INTEGER
);

CREATE TABLE workout (
    "id" INTEGER,
    "garmin_unit" INTEGER
, "name" TEXT, "sport_type" INTEGER);
CREATE TABLE steps (
    "id" INTEGER,
    "garmin_unit" INTEGER,
    "name" TEXT,
    "target_custom_zone_low" REAL,
    "target_custom_zone_high" REAL,
    "duration_value" INTEGER,
    "intensity" INTEGER,
    "duration_type" INTEGER,
    "target_type" INTEGER,
    "target_value" INTEGER
);
CREATE TABLE laps (
    "id" INTEGER,
    "garmin_unit" INTEGER,
    "index" INTEGER,
    "start_time" INTEGER,
    "total_time" INTEGER,
    "total_dist" REAL,
    "max_speed" REAL,
    "start_lat" INTEGER,
    "start_lon" INTEGER,
    "end_lat" INTEGER,
    "end_lon" INTEGER,
    "calories" INTEGER,
    "avg_heart_rage" INTEGER,
    "max_heart_rage" INTEGER,
    "intensity" INTEGER,
    "avg_cadence" INTEGER,
    "trigger_method" INTEGER,
    "type" INTEGER
);
