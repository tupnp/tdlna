################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../src/clients.c \
../src/main-app.c \
../src/main.c \
../src/proxy-client.c \
../src/tdlnamain.c \
../src/unpnssdp.c \
../src/upnpevents.c \
../src/upnpglobalvars.c \
../src/upnphttp.c \
../src/upnpsoap.c 

OBJS += \
./src/clients.o \
./src/main-app.o \
./src/main.o \
./src/proxy-client.o \
./src/tdlnamain.o \
./src/unpnssdp.o \
./src/upnpevents.o \
./src/upnpglobalvars.o \
./src/upnphttp.o \
./src/upnpsoap.o 

C_DEPS += \
./src/clients.d \
./src/main-app.d \
./src/main.d \
./src/proxy-client.d \
./src/tdlnamain.d \
./src/unpnssdp.d \
./src/upnpevents.d \
./src/upnpglobalvars.d \
./src/upnphttp.d \
./src/upnpsoap.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: C Compiler'
	$(CC) -I"pch" -D_DEBUG -I"$(PROJ_PATH)\inc" -O0 -g3 -Wall -c -fmessage-length=0 $(TC_COMPILER_MISC) $(RS_COMPILER_MISC) -fPIE --sysroot="$(SBI_SYSROOT)" -mthumb -I@system_includes -Werror-implicit-function-declaration -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


