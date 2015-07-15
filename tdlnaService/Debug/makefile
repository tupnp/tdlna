################################################################################
# Automatically-generated file. Do not edit!
################################################################################

-include ../makefile.init

RM := rm -rf

# All of the sources participating in the build are defined here
-include sources.mk
-include src/subdir.mk
-include subdir.mk
-include objects.mk
ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(CC_DEPS)),)
-include $(CC_DEPS)
endif
ifneq ($(strip $(C++_DEPS)),)
-include $(C++_DEPS)
endif
ifneq ($(strip $(C_UPPER_DEPS)),)
-include $(C_UPPER_DEPS)
endif
ifneq ($(strip $(CXX_DEPS)),)
-include $(CXX_DEPS)
endif
ifneq ($(strip $(CPP_DEPS)),)
-include $(CPP_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
endif

-include ../makefile.defs
-include makefile.sa
-include makefile.func

# Add inputs and outputs from these tool invocations to the build variables 

# All Target
all: tdlnaservice secondary-outputs

# Tool invocations
tdlnaservice: $(OBJS) $(USER_OBJS)
	@echo 'Building target: $@'
	@echo 'Invoking: C++ Linker'
	$(CXX) -o"tdlnaservice" $(OBJS) $(USER_OBJS) $(LIBS) -L"$(PROJ_PATH)\lib" $(TC_LINKER_MISC) $(RS_LINKER_MISC) -pie -lpthread -Xlinker -rpath="/home/developer/sdk_tools/lib" --sysroot="$(SBI_SYSROOT)" -Xlinker --version-script=$(PROJ_PATH)/.exportMap -L"$(SBI_SYSROOT)/usr/lib" $(RS_LIBRARIES) -Xlinker -rpath="/opt/usr/apps/$(APPID)/lib" -Werror-implicit-function-declaration
	@echo 'Finished building target: $@'
	@echo ' '

# Other Targets
clean: sa_clean
	-$(RM) $(AST)$(CC_DEPS)$(C++_DEPS)$(MO_FILES)$(EXECUTABLES)$(C_UPPER_DEPS)$(CXX_DEPS)$(OBJS)$(FNMAP)$(EDJ_FILES)$(CPP_DEPS)$(C_DEPS) tdlnaservice
	-@echo ' '

secondary-outputs: $(MO_FILES) $(EDJ_FILES)

.PHONY: all clean dependents
.SECONDARY:

-include ../makefile.targets
