from enum import Enum, auto

class TaxCode (Enum):
    LOWINCOME = auto()
    MIDDLEINCOME = auto()
    HIGHINCOME = auto()